using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class LoginTable
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int? IdAdministrator { get; set; }
        public int? IdStudent { get; set; }

        public virtual Administrator IdAdministratorNavigation { get; set; }
        public virtual Administrator IdStudentNavigation { get; set; }
    }
}
