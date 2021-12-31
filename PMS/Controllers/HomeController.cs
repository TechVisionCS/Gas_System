using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;
using System.Diagnostics;

namespace PMS.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHelperRepository helperRepository;

        public HomeController(ILogger<HomeController> logger, IHelperRepository helperRepository)
        {
            _logger = logger;
            this.helperRepository = helperRepository;
        }


        [HttpGet]
        public JsonResult GetProvincesByID(long id) //Province From Countries Id ...
        {
            var provinces = helperRepository.GetProvincesById(id);
            return Json(provinces);
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddHours(12) }
                );
            return LocalRedirect(returnUrl);
        }


        [HttpPost]
        public IActionResult CultureManagment(string culture)
        {
            Response.Cookies.Append(
                   CookieRequestCultureProvider.DefaultCookieName,
                   CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                   new CookieOptions { Expires = DateTimeOffset.UtcNow.AddHours(10) }
                   );
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
