using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MyGlobalApp.Controllers
{
    public class LocalizationController : Controller
    {
        private readonly IStringLocalizer<LocalizationController> _localizer;

        public LocalizationController(IStringLocalizer<LocalizationController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            return View();
        }
    }
}
