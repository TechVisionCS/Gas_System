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
            string[] _folderPath = Directory.GetFiles(Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups/"));

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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);// will give the user's userId
            //var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName

            //ApplicationUser applicationUser = await userManager.GetUserAsync(User);
            //string UserName = applicationUser?.FullName; // will give the user's Email
            var UserNameFromHelper = helperRepository.GetUserName(userId);

            string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups/");
            string ConectionStrings = configuration.GetConnectionString("LocalConnectionString");
            var sqlConStrBuilder = new SqlConnectionStringBuilder(ConectionStrings);
            var backupFileName = $@"{_folderPath}\{sqlConStrBuilder.InitialCatalog}({DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss-tt_") + UserNameFromHelper}).bak";

            if (!System.IO.Directory.Exists(_folderPath))
            {
                System.IO.Directory.CreateDirectory(_folderPath);
            }
            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                var query = $"BACKUP DATABASE [{sqlConStrBuilder.InitialCatalog}] TO DISK='{backupFileName}'";
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
            string path = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }

        [HttpGet]
        public async Task<IActionResult> RestoreDatabase(string fileName)
        {
            //  string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups");
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);// will give the user's userId
            //var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName

            //ApplicationUser applicationUser = await userManager.GetUserAsync(User);
            //string UserName = applicationUser?.FullName; // will give the user's Email
            var UserNameFromHelper = helperRepository.GetUserName(userId);

            string _folderPath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups/") + fileName;
            string ConectionStrings = configuration.GetConnectionString("LocalConnectionString");
            var sqlConStrBuilder = new SqlConnectionStringBuilder(ConectionStrings);
            //var backupFileName = $@"{_folderPath}\{sqlConStrBuilder.InitialCatalog}({DateTime.Now.Date.ToString("yyyy-MM-dd")}).bak";

            //if (!System.IO.Directory.Exists(_folderPath))
            //{
            //    System.IO.Directory.CreateDirectory(_folderPath);
            //}
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

            string path = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/Backups/") + fileName;
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

        //  new SqlCommand(String.Format("USE [master]; RESTORE DATABASE [DBName] FROM DISK='{0}' WITH REPLACE;", BakFilePath), connectionName);
        //ServerConnection serverConnection = new ServerConnection("192.168.1.1", "user", "password");
        //Server server = new Server(serverConnection);
        //Database database = server.Databases["AdventureWorks"];
        //Backup backup = new Backup();
        //backup.Action = BackupActionType.Database;
        //    backup.BackupSetDescription = "AdventureWorks - full backup";
        //    backup.BackupSetName = "AdventureWorks backup";
        //    backup.Database = "AdventureWorks";

        //    BackupDeviceItem deviceItem = new BackupDeviceItem("AdventureWorks_Full_Backup.bak", DeviceType.File);
        //backup.Devices.Add(deviceItem);
        //    backup.Incremental = false;
        //    backup.LogTruncation = BackupTruncateLogType.Truncate;
        //    backup.SqlBackup(server);


        //        using System;
        //using System.Data;
        //using System.Data.SqlClient;

        //namespace BackupRestore
        //    {
        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                BackupDatabase("test", @"C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Backup\test.bak");
        //                RestoreDatabase("test", @"C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Backup\test.bak");
        //            }

        //            private static void RestoreDatabase(string databaseName, string backupPath)
        //            {
        //                string commandText = $@"USE [master];
        //    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        //    RESTORE DATABASE [{databaseName}] FROM DISK = N'{backupPath}' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5;
        //    ALTER DATABASE [{databaseName}] SET MULTI_USER;";

        //                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder
        //                {
        //                    DataSource = "localhost",
        //                    InitialCatalog = "master",
        //                    IntegratedSecurity = true
        //                };
        //                using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
        //                {
        //                    connection.Open();
        //                    connection.InfoMessage += Connection_InfoMessage;
        //                    using (SqlCommand command = connection.CreateCommand())
        //                    {
        //                        command.CommandText = commandText;
        //                        command.CommandType = CommandType.Text;
        //                        command.ExecuteNonQuery();
        //                    }
        //                }
        //            }

        //public void BackupDatabaseOther(string databaseName, string backupPath)
        //  {
        //      string commandText = $@"BACKUP DATABASE [{databaseName}] TO DISK = N'{backupPath}' WITH NOFORMAT, INIT, NAME = N'{databaseName}-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

        //      string ConectionStrings = configuration.GetConnectionString("LocalConnectionString");
        //      var sqlConStrBuilder = new SqlConnectionStringBuilder(ConectionStrings);

        //      using (SqlConnection connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
        //      {
        //          connection.Open();
        //          connection.InfoMessage += Connection_InfoMessage;
        //          using (SqlCommand command = connection.CreateCommand())
        //          {
        //              command.CommandText = commandText;
        //              command.CommandType = CommandType.Text;
        //              command.ExecuteNonQuery();
        //          }
        //      }
        //  }

        //private static void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //        }
        //    }
        ////    
        ///To RESTORE a database with new name for example newtest, you need execute next statement

        ////RESTORE DATABASE[newtest]
        ////FROM DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Backup\test.bak' WITH FILE = 1,
        ////MOVE N'test' TO N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\newtest.mdf',  
        ////MOVE N'test_log' TO N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\newtest_log.ldf',  NOUNLOAD,  STATS = 5


    }
}
