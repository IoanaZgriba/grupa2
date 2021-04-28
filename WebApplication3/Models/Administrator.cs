using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            Tichet = new HashSet<Tichet>();
        }

        public int IdAdministrator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int NrTelefon { get; set; }
        public string Email { get; set; }
        public int IdCamin { get; set; }

        public virtual Camin IdCaminNavigation { get; set; }
        public virtual ICollection<Tichet> Tichet { get; set; }
    }
}
