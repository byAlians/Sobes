using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Models.ModelForDB.ModelSubdivision
{
    public class Subdivision:Building
    {
        [Display(Name = "Номер подразделения")]
        public int SubdivisionNumber { get; set; }

        [Display(Name = "Подразделение")]
        public string NameSubdivision { get; set; }

        public ICollection<Staff> Staff { get; set; }

        public Subdivision()
        {
            Staff = new List<Staff>();
        }
    }
}