using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class BackupController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IConfiguration configuration;
        private readonly IHelperRepository helperRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public BackupController(IConfiguration configuration,
            IWebHostEnvironment webHostEnvironment,
            IHelperRepository helperRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {

            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.configuration = configuration;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            string[] _folderPath = Directory.GetFiles(Path.Combine(webHostEnvironment.WebRootPath, "Backup"));

            //Copy File names to Model collection.
            List<FileList> files = new List<FileList>();
            foreach (string filePath in _folderPath)
            {
                files.Add(new FileList { FileName = Path.GetFileName(filePath) });
            }

            return View(files);
        }


        // GET: Backup
        public async Task<IActionResult> BackupDatabase()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // will give the user's userId

            //var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName

            //ApplicationUser applicationUser = await userManager.GetUserAsync(User);

            //string UserName = applicationUser?.FullName; // will give the user's Email

            //var UserNameFromHelper = helperRepository.GetUserName(userId);

            string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Backup");

            string ConectionStrings = configuration.GetConnectionString("LocalConnectionString");

            var sqlConStrBuilder = new SqlConnectionStringBuilder(ConectionStrings);

            var backupFileName = $@"{_folderPath}\{sqlConStrBuilder.InitialCatalog}({DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss-tt")}).bak";

            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                var query = $"USE Master; BACKUP DATABASE [{sqlConStrBuilder.InitialCatalog}] TO DISK='{backupFileName}'";

                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        await connection.OpenAsync();

                        await command.ExecuteNonQueryAsync();

                        helperRepository.InfoMessage("Backup Done Succesfully into System");

                        return RedirectToAction("Index", "Backup");
                    }
                    catch (Exception ex)
                    {
                        helperRepository.WarningMessage("Backup encountered a problem" + ex.Message);

                        return RedirectToAction("Index", "Backup");
                    }
                }
            }
        }

        public FileResult DownloadFile(string fileName)
        {
            //Build the File Path.

            string path = Path.Combine(webHostEnvironment.WebRootPath, "Backup") + fileName;

            //Read the File data into Byte Array.

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.

            return File(bytes, "application/octet-stream", fileName);
        }

        [HttpGet]
        public async Task<IActionResult> RestoreDatabase(string fileName)
        {
            //  string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups");

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // will give the user's userId                                                           

            //var userName = User.FindFirstValue(ClaimTypes.Name); 

            //will give the user's userName

            //ApplicationUser applicationUser = await userManager.GetUserAsync(User);

            //string UserName = applicationUser?.FullName; // will give the user's Email

            var UserNameFromHelper = helperRepository.GetUserName(userId);

            string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Backup") + fileName;

            string ConectionStrings = configuration.GetConnectionString("LocalConnectionString");

            var sqlConStrBuilder = new SqlConnectionStringBuilder(ConectionStrings);

            //var backupFileName = $@"{_folderPath}\{sqlConStrBuilder.InitialCatalog}({DateTime.Now.Date.ToString("yyyy-MM-dd")}).bak";

            byte[] bytes = System.IO.File.ReadAllBytes(_folderPath);

            //Send the File to Download.

            var location = File(bytes, "application/octet-stream", fileName);

            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                var query = $"USE Master;  ALTER DATABASE [{sqlConStrBuilder.InitialCatalog}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [{sqlConStrBuilder.InitialCatalog}] From DISK='{_folderPath}' WITH REPLACE; ALTER DATABASE [{sqlConStrBuilder.InitialCatalog}] SET MULTI_USER;";

                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        await connection.OpenAsync();

                        await command.ExecuteNonQueryAsync();

                        helperRepository.InfoMessage("Restore Done Successfuly From Folder");

                        return RedirectToAction("Index", "Backup");
                    }
                    catch (Exception ex)
                    {
                        helperRepository.WarningMessage("Restore encountered a problem" + ex.Message);

                        return RedirectToAction("Index", "Backup");
                    }
                }
            }
        }


        [HttpGet]
        public IActionResult DeleteFile(string fileName)
        {
            string path = Path.Combine(webHostEnvironment.WebRootPath, "Backup") + fileName;

            try

            {

                if (System.IO.File.Exists(path))

                {
                    System.IO.File.Delete(path);
                }
                helperRepository.InfoMessage("File Deleted Successfuly");

                return RedirectToAction("Index", "Backup");
            }
            catch (Exception ex)
            {
                helperRepository.WarningMessage("Deletation encountered a problem" + ex.Message);

                return RedirectToAction("Index", "Backup");
            }
        }
    }
}
