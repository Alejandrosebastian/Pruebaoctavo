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
    public class DesempleadoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DesempleadoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Desempleadoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Desempleado.ToListAsync());
        }

        // GET: Desempleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempleado = await _context.Desempleado
                .SingleOrDefaultAsync(m => m.DesempleadoId == id);
            if (desempleado == null)
            {
                return NotFound();
            }

            return View(desempleado);
        }

        // GET: Desempleadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Desempleadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DesempleadoId,tiempo,fecha_ini,fecha_fin")] Desempleado desempleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(desempleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(desempleado);
        }

        // GET: Desempleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempleado = await _context.Desempleado.SingleOrDefaultAsync(m => m.DesempleadoId == id);
            if (desempleado == null)
            {
                return NotFound();
            }
            return View(desempleado);
        }

        // POST: Desempleadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DesempleadoId,tiempo,fecha_ini,fecha_fin")] Desempleado desempleado)
        {
            if (id != desempleado.DesempleadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desempleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesempleadoExists(desempleado.DesempleadoId))
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
            return View(desempleado);
        }

        // GET: Desempleadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempleado = await _context.Desempleado
                .SingleOrDefaultAsync(m => m.DesempleadoId == id);
            if (desempleado == null)
            {
                return NotFound();
            }

            return View(desempleado);
        }

        // POST: Desempleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var desempleado = await _context.Desempleado.SingleOrDefaultAsync(m => m.DesempleadoId == id);
            _context.Desempleado.Remove(desempleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesempleadoExists(int id)
        {
            return _context.Desempleado.Any(e => e.DesempleadoId == id);
        }
    }
}
