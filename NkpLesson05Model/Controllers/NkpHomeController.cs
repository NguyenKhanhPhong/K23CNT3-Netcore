using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NkpLesson05Model.Models;
using NkpLesson05Model.Models.DataModels;

namespace NkpLesson05Model.Controllers
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
            NkpMember nkpMember = new NkpMember();
            nkpMember.NkpMemberId = Guid.NewGuid().ToString();
            nkpMember.NkpUserName = "PhongNguyen";
            nkpMember.NkpPassword = "123456a@";
            nkpMember.NkpFullName = "Nguyễn Khánh Phong";
            nkpMember.NkpEmail = "KhanhPhong@gmail.com";
            return View(nkpMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
