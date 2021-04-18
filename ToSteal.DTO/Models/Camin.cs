using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ToSteal.DTO.Models
{
    public partial class Camin
    {
        public Camin()
        {
            Administrator = new HashSet<Administrator>();
            Camera = new HashSet<Camera>();
        }

        public int IdCamin { get; set; }
        public string Adresa { get; set; }
        public int NrCamere { get; set; }
        public string Poza { get; set; }
        public bool BaieComuna { get; set; }
        public bool BucatarieComuna { get; set; }
        public int IdTaxa { get; set; }

        public virtual Taxa IdTaxaNavigation { get; set; }
        public virtual ICollection<Administrator> Administrator { get; set; }
        public virtual ICollection<Camera> Camera { get; set; }
    }
}
