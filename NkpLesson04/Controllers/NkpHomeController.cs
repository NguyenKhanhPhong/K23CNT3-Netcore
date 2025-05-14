using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NkpLesson04.Models;

namespace NkpLesson04.Controllers
{
    public class NkpHomeController : Controller
    {
        private readonly ILogger<NkpHomeController> _logger;

        public NkpHomeController(ILogger<NkpHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NkpIndex()
        {
            return View();
        }

        public IActionResult NkpAbout()
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
