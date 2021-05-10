using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class StudentList
    {
        public StudentList()
        { }
      public string Nume { get; set; }
      public string Prenume { get; set;}
        [Key]
      public int Nr_telefon { get; set; }
      public string Nume_administrator { get; set; }

      public int Id_camera { get; set; }


    }
}
