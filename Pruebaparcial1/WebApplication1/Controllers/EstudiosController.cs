using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EstudiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstudiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estudios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudios.ToListAsync());
        }

        // GET: Estudios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios
                .SingleOrDefaultAsync(m => m.EstudiosId == id);
            if (estudios == null)
            {
                return NotFound();
            }

            return View(estudios);
        }

        // GET: Estudios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudiosId,Detalle")] Estudios estudios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudios);
        }

        // GET: Estudios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios.SingleOrDefaultAsync(m => m.EstudiosId == id);
            if (estudios == null)
            {
                return NotFound();
            }
            return View(estudios);
        }

        // POST: Estudios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudiosId,Detalle")] Estudios estudios)
        {
            if (id != estudios.EstudiosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudiosExists(estudios.EstudiosId))
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
            return View(estudios);
        }

        // GET: Estudios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios
                .SingleOrDefaultAsync(m => m.EstudiosId == id);
            if (estudios == null)
            {
                return NotFound();
            }

            return View(estudios);
        }

        // POST: Estudios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudios = await _context.Estudios.SingleOrDefaultAsync(m => m.EstudiosId == id);
            _context.Estudios.Remove(estudios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudiosExists(int id)
        {
            return _context.Estudios.Any(e => e.EstudiosId == id);
        }
    }
}
