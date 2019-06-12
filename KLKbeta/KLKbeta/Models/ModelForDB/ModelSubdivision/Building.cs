using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KLKbeta.Models.ModelForDB.ModelSubdivision
{
    public abstract class Building
    {
        public int Id { get; set; }
        [Display(Name = "Город")]
        public string City { get; set; }
        [Display(Name = "Улица")]
        public string Street { get; set; }
        [Display(Name = "Номер")]
        public int Number { get; set; }
        [Display(Name = "Индекс")]
        public char? Index { get; set; }
    }
}