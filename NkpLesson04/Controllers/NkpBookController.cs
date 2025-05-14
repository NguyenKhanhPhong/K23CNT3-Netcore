using Microsoft.AspNetCore.Mvc;
using NkpLesson04.Models;

namespace NkpLesson04.Controllers
{
    public class NkpBookController : Controller
    {
        List<NkpBook> NkpBooks = new List<NkpBook>
{
    new NkpBook
    {
        NkpId = "B001",
        NkpTitle = "..... ",
        NkpDescription = "A comprehensive guide to learning C# for beginners.",
        NkpImage = "/images/Book-1.jpg",
        NkpPrice = 120000f,
        NkpPage = 320
    },
    new NkpBook
    {
        NkpId = "B002",
        NkpTitle = "asdasd",
        NkpDescription = "Advanced concepts and real-world projects with ASP.NET Core.",
        NkpImage = "/images/Book-2.jpg",
        NkpPrice = 130000f,
        NkpPage = 450
    },
    new NkpBook
    {
        NkpId = "B003",
        NkpTitle = "asdasdddd",
        NkpDescription = "Learn data access in .NET using Entity Framework Core.",
        NkpImage = "/images/Book-3.jpg",
        NkpPrice = 140000f,
        NkpPage = 380
    },
    new NkpBook
    {
        NkpId = "B004",
        NkpTitle = "asdasd1",
        NkpDescription = ".",
        NkpImage = "/images/Book-4.jpg",
        NkpPrice = 150000f,
        NkpPage = 310
    },
    new NkpBook
    {
        NkpId = "B005",
        NkpTitle = "asdsad23",
        NkpDescription = ".",
        NkpImage = "/images/Book-5.jpg",
        NkpPrice = 160000f,
        NkpPage = 400
    }
};

        public IActionResult NkpIndex()
        {

            return View(NkpBooks);
        }
        public IActionResult NkpCreate()
        {
            NkpBook nkpBook = new NkpBook();
            return View(nkpBook);
        }
        public IActionResult NkpCreateSubmit()
        {

            return RedirectToAction("NkpIndex");
        }
        public IActionResult NkpEdit(string id)
        {

            return View();
        }
        public IActionResult NkpEditSubmit()
        {

            return RedirectToAction("NkpIndex");
        }
    }
}
