using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDashboardApp.Controllers {
    [Route("[controller]/[action]")]
    public class CultureController : Controller {
        public IActionResult Set(string culture, string uiCulture, string redirectUri) {
            if(culture != null && uiCulture != null) {
                HttpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(
                        new RequestCulture(culture, uiCulture)
                    )
                );
            }
            return LocalRedirect(redirectUri);
        }
    }
}