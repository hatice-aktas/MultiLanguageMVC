using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
//using MultiLanguageMVC.Services.Lang;
using System.ComponentModel.Design;
using System.Globalization;

namespace MultiLanguageMVC.Controllers.Lang
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                                    new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
