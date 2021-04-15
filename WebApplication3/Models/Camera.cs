using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class Camera
    {
        public Camera()
        {
            Student = new HashSet<Student>();
        }

        public int IdCamera { get; set; }
        public int Etaj { get; set; }
        public int NrPaturi { get; set; }
        public int NrMobilier { get; set; }
        public int IdCamin { get; set; }

        public virtual Camin IdCaminNavigation { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
