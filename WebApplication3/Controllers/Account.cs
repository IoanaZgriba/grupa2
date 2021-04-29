using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers
{
    public class Account : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        private readonly uvtdemosdbContext _context = new uvtdemosdbContext();

        //       public string username { get; private set; }
        //        public string password { get; private set; }

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
                    con.Close();
                    return View("/Views/Administrators/Index.cshtml", new List<Administrator>());
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
