using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class CaminsController : Controller
    {
        private readonly uvtdemosdbContext _context;

        public CaminsController(uvtdemosdbContext context)
        {
            _context = context;
        }

        // GET: Camins
        public async Task<IActionResult> Index()
        {
            var uvtdemosdbContext = _context.Camin.Include(c => c.IdTaxaNavigation);
            return View(await uvtdemosdbContext.ToListAsync());
        }

        // GET: Camins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camin = await _context.Camin
                .Include(c => c.IdTaxaNavigation)
                .FirstOrDefaultAsync(m => m.IdCamin == id);
            if (camin == null)
            {
                return NotFound();
            }

            return View(camin);
        }

        // GET: Camins/Create
        public IActionResult Create()
        {
            ViewData["IdTaxa"] = new SelectList(_context.Taxa, "IdTaxa", "IdTaxa");
            return View();
        }

        // POST: Camins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCamin,Adresa,NrCamere,Poza,BaieComuna,BucatarieComuna,IdTaxa")] Camin camin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdTaxa"] = new SelectList(_context.Taxa, "IdTaxa", "IdTaxa", camin.IdTaxa);
            return View(camin);
        }

        // GET: Camins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camin = await _context.Camin.FindAsync(id);
            if (camin == null)
            {
                return NotFound();
            }
            ViewData["IdTaxa"] = new SelectList(_context.Taxa, "IdTaxa", "IdTaxa", camin.IdTaxa);
            return View(camin);
        }

        // POST: Camins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCamin,Adresa,NrCamere,Poza,BaieComuna,BucatarieComuna,IdTaxa")] Camin camin)
        {
            if (id != camin.IdCamin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaminExists(camin.IdCamin))
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
            ViewData["IdTaxa"] = new SelectList(_context.Taxa, "IdTaxa", "IdTaxa", camin.IdTaxa);
            return View(camin);
        }

        // GET: Camins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camin = await _context.Camin
                .Include(c => c.IdTaxaNavigation)
                .FirstOrDefaultAsync(m => m.IdCamin == id);
            if (camin == null)
            {
                return NotFound();
            }

            return View(camin);
        }

        // POST: Camins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var camin = await _context.Camin.FindAsync(id);
            _context.Camin.Remove(camin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaminExists(int id)
        {
            return _context.Camin.Any(e => e.IdCamin == id);
        }
    }
}
