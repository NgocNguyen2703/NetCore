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
    public class KetQuaController : Controller
    {
        private readonly MvcMovieContext _context;

        public KetQuaController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: KetQua
        public async Task<IActionResult> Index()
        {
            return View(await _context.KetQua.ToListAsync());
        }

        // GET: KetQua/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ketQua = await _context.KetQua
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ketQua == null)
            {
                return NotFound();
            }

            return View(ketQua);
        }

        // GET: KetQua/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KetQua/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaMonHocID,Diem")] KetQua ketQua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ketQua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ketQua);
        }

        // GET: KetQua/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ketQua = await _context.KetQua.FindAsync(id);
            if (ketQua == null)
            {
                return NotFound();
            }
            return View(ketQua);
        }

        // POST: KetQua/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,MaMonHocID,Diem")] KetQua ketQua)
        {
            if (id != ketQua.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ketQua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KetQuaExists(ketQua.Id))
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
            return View(ketQua);
        }

        // GET: KetQua/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ketQua = await _context.KetQua
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ketQua == null)
            {
                return NotFound();
            }

            return View(ketQua);
        }

        // POST: KetQua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ketQua = await _context.KetQua.FindAsync(id);
            _context.KetQua.Remove(ketQua);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KetQuaExists(string id)
        {
            return _context.KetQua.Any(e => e.Id == id);
        }
    }
}
