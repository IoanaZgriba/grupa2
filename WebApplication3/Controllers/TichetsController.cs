using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TichetsController : Controller
    {
        private readonly uvtdemosdbContext _context;

        public TichetsController(uvtdemosdbContext context)
        {
            _context = context;
        }

        // GET: Tichets
        public async Task<IActionResult> Index()
        {
            var uvtdemosdbContext = _context.Tichet.Include(t => t.CnpStudentNavigation).Include(t => t.IdAdministratorNavigation);
            return View(await uvtdemosdbContext.ToListAsync());
        }

        // GET: Tichets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tichet = await _context.Tichet
                .Include(t => t.CnpStudentNavigation)
                .Include(t => t.IdAdministratorNavigation)
                .FirstOrDefaultAsync(m => m.IdTichet == id);
            if (tichet == null)
            {
                return NotFound();
            }

            return View(tichet);
        }

        // GET: Tichets/Create
        public IActionResult Create()
        {
            ViewData["CnpStudent"] = new SelectList(_context.Student, "Cnp", "Email");
            ViewData["IdAdministrator"] = new SelectList(_context.Administrator, "IdAdministrator", "Nume");
            return View();
        }

        // POST: Tichets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTichet,CnpStudent,IdAdministrator,DescriereTichet,Urgenta")] Tichet tichet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tichet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CnpStudent"] = new SelectList(_context.Student, "Cnp", "Email", tichet.CnpStudent);
            ViewData["IdAdministrator"] = new SelectList(_context.Administrator, "IdAdministrator", "Nume", tichet.IdAdministrator);
            return View(tichet);
        }

        // GET: Tichets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tichet = await _context.Tichet.FindAsync(id);
            if (tichet == null)
            {
                return NotFound();
            }
            ViewData["CnpStudent"] = new SelectList(_context.Student, "Cnp", "Email", tichet.CnpStudent);
            ViewData["IdAdministrator"] = new SelectList(_context.Administrator, "IdAdministrator", "Nume", tichet.IdAdministrator);
            return View(tichet);
        }

        // POST: Tichets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTichet,CnpStudent,IdAdministrator,DescriereTichet,Urgenta")] Tichet tichet)
        {
            if (id != tichet.IdTichet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tichet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TichetExists(tichet.IdTichet))
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
            ViewData["CnpStudent"] = new SelectList(_context.Student, "Cnp", "Email", tichet.CnpStudent);
            ViewData["IdAdministrator"] = new SelectList(_context.Administrator, "IdAdministrator", "Nume", tichet.IdAdministrator);
            return View(tichet);
        }

        // GET: Tichets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tichet = await _context.Tichet
                .Include(t => t.CnpStudentNavigation)
                .Include(t => t.IdAdministratorNavigation)
                .FirstOrDefaultAsync(m => m.IdTichet == id);
            if (tichet == null)
            {
                return NotFound();
            }

            return View(tichet);
        }

        // POST: Tichets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tichet = await _context.Tichet.FindAsync(id);
            _context.Tichet.Remove(tichet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TichetExists(int id)
        {
            return _context.Tichet.Any(e => e.IdTichet == id);
        }
    }
}
