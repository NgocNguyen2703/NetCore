using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCORE.Data;
using NETCORE.Models;

namespace DemoNetCore.Controllers
{
    public class PhieuXuatController : Controller
    {
        private readonly MvcMovieContext _context;

        public PhieuXuatController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: PhieuXuat
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhieuXuat.ToListAsync());
        }

        // GET: PhieuXuat/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuXuat = await _context.PhieuXuat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phieuXuat == null)
            {
                return NotFound();
            }

            return View(phieuXuat);
        }

        // GET: PhieuXuat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhieuXuat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UnitPrice,Quantity,NgayXuat")] PhieuXuat phieuXuat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuXuat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuat/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuXuat = await _context.PhieuXuat.FindAsync(id);
            if (phieuXuat == null)
            {
                return NotFound();
            }
            return View(phieuXuat);
        }

        // POST: PhieuXuat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,UnitPrice,Quantity,NgayXuat")] PhieuXuat phieuXuat)
        {
            if (id != phieuXuat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuXuat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuXuatExists(phieuXuat.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuat/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuXuat = await _context.PhieuXuat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phieuXuat == null)
            {
                return NotFound();
            }

            return View(phieuXuat);
        }

        // POST: PhieuXuat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var phieuXuat = await _context.PhieuXuat.FindAsync(id);
            _context.PhieuXuat.Remove(phieuXuat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuXuatExists(string id)
        {
            return _context.PhieuXuat.Any(e => e.Id == id);
        }
    }
}
