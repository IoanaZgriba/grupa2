using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class Student
    {
        public long Cnp { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int NrTelefon { get; set; }
        public string Facultate { get; set; }
        public int AnStudiu { get; set; }
        public decimal Medie { get; set; }
        public string Sex { get; set; }
        public int Varsta { get; set; }
        public string Email { get; set; }
        public int? LuniRestante { get; set; }
        public string Statut { get; set; }
        public int IdCamera { get; set; }

        public virtual Camera IdCameraNavigation { get; set; }
    }
}
