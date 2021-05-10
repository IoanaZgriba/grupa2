using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    
public class Account : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader dr2;

        private readonly uvtdemosdbContext _context = new uvtdemosdbContext();

    

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void ConnectionString()
        {
            con.ConnectionString = "Server=tcp:uvt-demos-server2.database.windows.net,1433;Initial Catalog=uvt-demos-db;Persist Security Info=False;User ID=adminUser;Password=Alexandru3973;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        }
        [HttpPost]
        public ActionResult Verify(Account1 acc) 
        {
            ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from dbo.LOGIN_TABLE where username='"+acc.Username+ "' and password='"+acc.Password + "'";
            dr = com.ExecuteReader();

           
            if (dr.Read())
            {
                string temp = dr.GetValue(0).ToString();
                if (temp.Contains("admin_"))
                {
                    string[] temp_string = temp.Split("_");
                    con.Close();
                    ConnectionString();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "select * from dbo.ADMINISTRATOR where nume='" + temp_string[1] + "'";
                    dr2 = com.ExecuteReader();
                   Administrator admin = new Administrator();
                    
                    dr2.Read();
                    admin.IdAdministrator =Int32.Parse(dr2.GetValue(0).ToString());
                    admin.Nume = dr2.GetValue(1).ToString();
                    admin.Prenume = dr2.GetValue(2).ToString();
                    admin.NrTelefon = Int32.Parse(dr2.GetValue(3).ToString());
                    admin.Email = dr2.GetValue(4).ToString();
                    admin.IdCamin = Int32.Parse(dr2.GetValue(5).ToString());
                    List<Administrator> administrator = new List<Administrator>();
                    administrator.Add(admin);
                    TempAdmin.ad = admin;

                    con.Close();
                    return View("/Views/Administrators/Index.cshtml", administrator);
                }
                if (temp.Contains("stud_"))
                {
                    var uvtdemosdbContext = _context.Student.Include(s => s.IdCameraNavigation);
                    con.Close();
                    return View("/Views/Students/Index.cshtml", uvtdemosdbContext.ToList());
                }

            }
                con.Close();
                return View("Error");

            
            
        }
    }
}
