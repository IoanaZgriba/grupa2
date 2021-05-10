using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

namespace WebApplication3.Models
{
    public class StudentsController : Controller
    {
        List<StudentList> ListaStudenti = new List<StudentList>();
        SqlConnection con1 = new SqlConnection();
        SqlCommand com1 = new SqlCommand();
        SqlDataReader dr1;

        private readonly uvtdemosdbContext _context;

        public StudentsController(uvtdemosdbContext context)
        {
            _context = context;
        }
        void ConnectionString()
        {
            con1.ConnectionString = "Server=tcp:uvt-demos-server2.database.windows.net,1433;Initial Catalog=uvt-demos-db;Persist Security Info=False;User ID=adminUser;Password=Alexandru3973;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        }
        // GET: Students
        public async Task<IActionResult> Index()
        {
          
            var uvtdemosdbContext = _context.Student.Include(s => s.IdCameraNavigation);
                       ConnectionString();
                       con1.Open();
                       com1.Connection = con1;
                       com1.CommandText = "SELECT [dbo].[STUDENT].nume,[dbo].[STUDENT].prenume,[dbo].[STUDENT].nr_telefon,[dbo].[ADMINISTRATOR].nume,[dbo].[CAMERA].id_camera FROM[dbo].[ADMINISTRATOR],[dbo].[CAMIN],[dbo].[CAMERA],[dbo].[STUDENT] WHERE[dbo].[ADMINISTRATOR].id_camin = [dbo].[CAMIN].id_camin AND[dbo].[CAMIN].id_camin = [dbo].[CAMERA].id_camin AND[dbo].[STUDENT].id_camera = [dbo].[CAMERA].id_camera";
                        dr1 = com1.ExecuteReader();
           
            
            while (dr1.Read())
                        {
                StudentList StudentTemp = new StudentList();
                StudentTemp.Nume = dr1.GetString(0);
                StudentTemp.Prenume = dr1.GetString(1);
                StudentTemp.Nr_telefon = dr1.GetInt32(2);
               StudentTemp.Nume_administrator = dr1.GetString(3);
                StudentTemp.Id_camera = dr1.GetInt32(4);
                ListaStudenti.Add(StudentTemp);
                        }
       
                    
                    

                return View("/Views/Students/Index.cshtml", ListaStudenti);
            
        }

             // GET: Students/Details/5
             public async Task<IActionResult> Details(long nr)
             {

            
                foreach(StudentList var in ListaStudenti)
                 {
                     if(var.Nr_telefon == 799229581)
                     {
                    List<StudentList> ListaStudent1 = new List<StudentList>();
                    ListaStudent1.Add(var);
                    return View("/Views/Students/Details.cshtml",ListaStudent1);
                     }
                 }
            return NotFound();
             }

            // GET: Students/Create
             public IActionResult Create()
             {
                 ViewData["IdCamera"] = new SelectList(_context.Camera, "IdCamera", "IdCamera");
                 return View();
             }

             // POST: Students/Create
             // To protect from overposting attacks, enable the specific properties you want to bind to, for 
             // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
             [HttpPost]
             [ValidateAntiForgeryToken]
             public async Task<IActionResult> Create([Bind("Cnp,Nume,Prenume,NrTelefon,Facultate,AnStudiu,Medie,Sex,Varsta,Email,LuniRestante,Statut,IdCamera")] Student student)
             {
                 if (ModelState.IsValid)
                 {
                     _context.Add(student);
                     await _context.SaveChangesAsync();
                     return RedirectToAction(nameof(Index));
                 }
                 ViewData["IdCamera"] = new SelectList(_context.Camera, "IdCamera", "IdCamera", student.IdCamera);
                 return View(student);
             }

             // GET: Students/Edit/5
             public async Task<IActionResult> Edit(long? id)
             {
                 if (id == null)
                 {
                     return NotFound();
                 }

                 var student = await _context.Student.FindAsync(id);
                 if (student == null)
                 {
                     return NotFound();
                 }
                 ViewData["IdCamera"] = new SelectList(_context.Camera, "IdCamera", "IdCamera", student.IdCamera);
                 return View(student);
             }

             // POST: Students/Edit/5
             // To protect from overposting attacks, enable the specific properties you want to bind to, for 
             // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
             [HttpPost]
             [ValidateAntiForgeryToken]
             public async Task<IActionResult> Edit(long id, [Bind("Cnp,Nume,Prenume,NrTelefon,Facultate,AnStudiu,Medie,Sex,Varsta,Email,LuniRestante,Statut,IdCamera")] Student student)
             {
                 if (id != student.Cnp)
                 {
                     return NotFound();
                 }

                 if (ModelState.IsValid)
                 {
                     try
                     {
                         _context.Update(student);
                         await _context.SaveChangesAsync();
                     }
                     catch (DbUpdateConcurrencyException)
                     {
                         if (!StudentExists(student.Cnp))
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
                 ViewData["IdCamera"] = new SelectList(_context.Camera, "IdCamera", "IdCamera", student.IdCamera);
                 return View(student);
             }

             // GET: Students/Delete/5
             public async Task<IActionResult> Delete(long? id)
             {
                 if (id == null)
                 {
                     return NotFound();
                 }

                 var student = await _context.Student
                     .Include(s => s.IdCameraNavigation)
                     .FirstOrDefaultAsync(m => m.Cnp == id);
                 if (student == null)
                 {
                     return NotFound();
                 }

                 return View(student);
             }

             // POST: Students/Delete/5
             [HttpPost, ActionName("Delete")]
             [ValidateAntiForgeryToken]
             public async Task<IActionResult> DeleteConfirmed(long id)
             {
                 var student = await _context.Student.FindAsync(id);
                 _context.Student.Remove(student);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }

             private bool StudentExists(long id)
             {
                 return _context.Student.Any(e => e.Cnp == id);
             }  
    }
}
