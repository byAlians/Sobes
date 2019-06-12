using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KLKbeta.Models.ModelForDB.ModelPeople
{
    public abstract class People
    {
        public int Id { get; set; }
        [Display(Name = "ФИО")]
        public string Name { get; set; }
        [Display(Name = "День рождения")]
        public DateTime Birthday { get; set; }
    }
}