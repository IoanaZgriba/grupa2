using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class Tichet
    {
        public int IdTichet { get; set; }
        public long CnpStudent { get; set; }
        public int IdAdministrator { get; set; }
        public string DescriereTichet { get; set; }
        public int? Urgenta { get; set; }

        public virtual Student CnpStudentNavigation { get; set; }
        public virtual Administrator IdAdministratorNavigation { get; set; }
    }
}
