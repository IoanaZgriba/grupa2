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
    public class StudentListsController : Controller
    {
        private readonly uvtdemosdbContext _context;

        public StudentListsController(uvtdemosdbContext context)
        {
            _context = context;
        }

        // GET: StudentLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentList.ToListAsync());
        }

        // GET: StudentLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentList = await _context.StudentList
                .FirstOrDefaultAsync(m => m.Nr_telefon == id);
            if (studentList == null)
            {
                return NotFound();
            }

            return View(studentList);
        }

        // GET: StudentLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nume,Prenume,Nr_telefon,Nume_administrator,Id_camera")] StudentList studentList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentList);
        }

        // GET: StudentLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentList = await _context.StudentList.FindAsync(id);
            if (studentList == null)
            {
                return NotFound();
            }
            return View(studentList);
        }

        // POST: StudentLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nume,Prenume,Nr_telefon,Nume_administrator,Id_camera")] StudentList studentList)
        {
            if (id != studentList.Nr_telefon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentListExists(studentList.Nr_telefon))
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
            return View(studentList);
        }

        // GET: StudentLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentList = await _context.StudentList
                .FirstOrDefaultAsync(m => m.Nr_telefon == id);
            if (studentList == null)
            {
                return NotFound();
            }

            return View(studentList);
        }

        // POST: StudentLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentList = await _context.StudentList.FindAsync(id);
            _context.StudentList.Remove(studentList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentListExists(int id)
        {
            return _context.StudentList.Any(e => e.Nr_telefon == id);
        }
    }
}
