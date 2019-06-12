using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLKbeta.Models.ModelForDB.ModelPeople
{
    public abstract class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}