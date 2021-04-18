using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ToSteal.DTO.Models
{
    public partial class Taxa
    {
        public Taxa()
        {
            Camin = new HashSet<Camin>();
        }

        public int IdTaxa { get; set; }
        public decimal Pret { get; set; }
        public string DescriereTaxa { get; set; }

        public virtual ICollection<Camin> Camin { get; set; }
    }
}
