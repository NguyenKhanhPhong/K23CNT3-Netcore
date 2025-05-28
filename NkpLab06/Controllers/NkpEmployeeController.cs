using Microsoft.AspNetCore.Mvc;
using NkpLab06.Models;

namespace NkpLab06.Controllers
{
    public class NkpEmployeeController : Controller
    {
        private static List<NkpEmployee> nkpListEmployee = new List<NkpEmployee>()
        {
            new NkpEmployee {NkpId = 1, NkpName= "Nguyễn Khánh Phong", NkpBirthDay = new DateTime(2005,7,31), NkpEmail = "nguyenphong@gmail.com", NkpPhone = "0375730295", NkpSalary = 12000000, NkpStatus = true },
            new NkpEmployee {NkpId = 2, NkpName= "Nguyễn Văn A", NkpBirthDay = new DateTime(2000,7,3), NkpEmail = "nguyena@gmail.com", NkpPhone = "0912345678", NkpSalary = 15000000, NkpStatus = true },
            new NkpEmployee {NkpId = 3, NkpName= "Nguyễn Thị B", NkpBirthDay = new DateTime(2003,5,23), NkpEmail = "nguyenb@gmail.com", NkpPhone = "0987654321", NkpSalary = 11000000, NkpStatus = false },
            new NkpEmployee {NkpId = 4, NkpName= "Trần Thị C", NkpBirthDay = new DateTime(2002,1,1), NkpEmail = "tranc@gmail.com", NkpPhone = "0123987655", NkpSalary = 13000000, NkpStatus = true },
            new NkpEmployee {NkpId = 5, NkpName= "Trịnh Trần Phương T", NkpBirthDay = new DateTime(1997,4,12), NkpEmail = "phuongtuanjack97@gmail.com", NkpPhone = "0853471722", NkpSalary = 1, NkpStatus = false }
        };
        public IActionResult NkpIndex()
        {
            return View(nkpListEmployee);
        }
        public IActionResult NkpCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NkpCreate(NkpEmployee model)
        {   
            if (ModelState.IsValid) 
            {
            int newId = nkpListEmployee.Any() ? nkpListEmployee.Max(e => e.NkpId) + 1 : 1;
            model.NkpId = newId;

            nkpListEmployee.Add(model);

            return RedirectToAction("NkpIndex");
            }
            return View(model);
        }
    }
}
