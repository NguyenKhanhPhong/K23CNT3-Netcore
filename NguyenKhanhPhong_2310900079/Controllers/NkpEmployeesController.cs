// Controller: NkpEmployeesController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenTrongHung_2310900039.Models;

namespace NguyenTrongHung_2310900039.Controllers
{
    public class NkpEmployeesController : Controller
    {
        private readonly NguyenTrongHung2310900039Context _context;

        public NkpEmployeesController(NguyenTrongHung2310900039Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> NkpIndex()
        {
            return View(await _context.NkpEmployees.ToListAsync());
        }

        public async Task<IActionResult> NkpDetails(int? NkpId)
        {
            if (NkpId == null) return NotFound();
            var emp = await _context.NkpEmployees.FirstOrDefaultAsync(m => m.NkpEmpId == NkpId);
            return emp == null ? NotFound() : View(emp);
        }

        public IActionResult NkpCreate() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NkpCreate(NkpEmployee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NkpIndex));
            }
            return View(emp);
        }

        public async Task<IActionResult> NkpEdit(int? NkpId)
        {
            if (NkpId == null) return NotFound();
            var emp = await _context.NkpEmployees.FindAsync(NkpId);
            return emp == null ? NotFound() : View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NkpEdit(int NkpId, NkpEmployee emp)
        {
            if (NkpId != emp.NkpEmpId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.NkpEmployees.Any(e => e.NkpEmpId == emp.NkpEmpId))
                        return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(NkpIndex));
            }
            return View(emp);
        }

        public async Task<IActionResult> NkpDelete(int? NkpId)
        {
            if (NkpId == null) return NotFound();
            var emp = await _context.NkpEmployees.FirstOrDefaultAsync(m => m.NkpEmpId == NkpId);
            return emp == null ? NotFound() : View(emp);
        }

        [HttpPost, ActionName("NkpDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NkpDeleteConfirmed(int NkpId)
        {
            var emp = await _context.NkpEmployees.FindAsync(NkpId);
            if (emp != null)
            {
                _context.NkpEmployees.Remove(emp);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(NkpIndex));
        }
    }
}