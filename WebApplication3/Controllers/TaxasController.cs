using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class TaxasController : Controller
    {
        private readonly uvtdemosdbContext _context;

        public TaxasController(uvtdemosdbContext context)
        {
            _context = context;
        }

        // GET: Taxas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Taxa.ToListAsync());
        }

        // GET: Taxas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa
                .FirstOrDefaultAsync(m => m.IdTaxa == id);
            if (taxa == null)
            {
                return NotFound();
            }

            return View(taxa);
        }

        // GET: Taxas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Taxas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTaxa,Pret,DescriereTaxa")] Taxa taxa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taxa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taxa);
        }

        // GET: Taxas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa.FindAsync(id);
            if (taxa == null)
            {
                return NotFound();
            }
            return View(taxa);
        }

        // POST: Taxas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTaxa,Pret,DescriereTaxa")] Taxa taxa)
        {
            if (id != taxa.IdTaxa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taxa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaxaExists(taxa.IdTaxa))
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
            return View(taxa);
        }

        // GET: Taxas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa
                .FirstOrDefaultAsync(m => m.IdTaxa == id);
            if (taxa == null)
            {
                return NotFound();
            }

            return View(taxa);
        }

        // POST: Taxas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taxa = await _context.Taxa.FindAsync(id);
            _context.Taxa.Remove(taxa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaxaExists(int id)
        {
            return _context.Taxa.Any(e => e.IdTaxa == id);
        }
    }
}
