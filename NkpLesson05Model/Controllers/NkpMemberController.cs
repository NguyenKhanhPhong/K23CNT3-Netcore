using Microsoft.AspNetCore.Mvc;
using NkpLesson05Model.Models.DataModels;

namespace NkpLesson05Model.Controllers
{
    public class NkpMemberController : Controller
    {
        private static List<NkpMember> nkpListMember = new List<NkpMember>()
        {
            new NkpMember
            {
                NkpMemberId = "M001",
                NkpUserName = "user1",
                NkpPassword = "pass1",
                NkpFullName = "Nguyễn Hoàng Huy",
                NkpEmail = "huy.nguyen@expamle.com"
            },
            new NkpMember
            {
                NkpMemberId = "M002",
                NkpUserName = "user2",
                NkpPassword = "pass2",
                NkpFullName = "Tran Thi B",
                NkpEmail = "user2@example.com"
            },
            new NkpMember
            {
                NkpMemberId = "M003",
                NkpUserName = "user3",
                NkpPassword = "pass3",
                NkpFullName = "Le Van C",
                NkpEmail = "user3@example.com"
            },
            new NkpMember
            {
                NkpMemberId = "M004",
                NkpUserName = "khanhphong",
                NkpPassword = "pass123",
                NkpFullName = "Nguyễn Khánh Phong",
                NkpEmail = "nguyen.phong@example.com"
            },
            new NkpMember
            {
                NkpMemberId = "M005",
                NkpUserName = "user5",
                NkpPassword = "pass5",
                NkpFullName = "Hoang Van E",
                NkpEmail = "user5@example.com"
            },
        };
        public IActionResult NkpIndex()
        {
            return View(nkpListMember);
        }
    }
}
