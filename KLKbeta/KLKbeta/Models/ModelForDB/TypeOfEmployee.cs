using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Models.ModelForDB
{
    public class TypeOfEmployee
    {
        public int Id { get; set; }
        [Display(Name = "Вид трудоустройства")]
        public string NameType { get; set; }

        public ICollection<Staff> Staff { get; set; }
        public TypeOfEmployee()
        {
            Staff = new List<Staff>();
        }
    }
}