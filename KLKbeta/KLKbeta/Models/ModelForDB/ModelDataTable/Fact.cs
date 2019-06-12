using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Models.ModelForDB.ModelDataTable
{
    public class Fact
    {
        public  int Id { get; set; }

        [Display(Name = "Часы")]
        private int Hour { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Staff> Staffs { get; set; }
        public Fact()
        {
            Staffs = new List<Staff>();
        }
    }
}