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
    public class Selection : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader dr1;
        private readonly uvtdemosdbContext _context = new uvtdemosdbContext();

        //       public string username { get; private set; }
        //        public string password { get; private set; }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public IActionResult Contact(CaminSpecific caminSpecific)
        {

            return View(caminSpecific);
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
            com.CommandText = "select id_camin from ADMINISTRATOR where nume='" + acc.Username + "'";
            dr = com.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            int temp1 = Int32.Parse(temp);
            com.CommandText = "select adresa from CAMIN where id_camin='" + temp1 + "'";
                                                                    
            dr1= com.ExecuteReader();
            
            CaminSpecific caminSpecific = new CaminSpecific();
            caminSpecific.NumeCamin = dr1.Read().ToString();
            Contact(caminSpecific);
            return View("/Views/Index.cshtml");

            con.Close();

            
            return View("Error");



        }
    }
}
