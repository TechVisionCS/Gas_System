using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace PMS.Controllers
{
    public class LanguageTradeController : Controller
    {
        public IActionResult Index()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            ViewBag.Date = DateTime.Now.ToLongDateString();
            ViewBag.Amount = String.Format("{0:C}", 56.88F);
            CultureInfo[] ci = CultureInfo.GetCultures(CultureTypes.AllCultures);
            ArrayList ar = new ArrayList();
            foreach (CultureInfo item in ci)
            {
                ar.Add(item.Name + "_" + item.EnglishName);
            }
            ViewBag.abc = ar;
            return View();
        }
    }
}
