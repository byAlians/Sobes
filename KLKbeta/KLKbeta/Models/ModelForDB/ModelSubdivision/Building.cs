using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLKbeta.Models.ModelForDB.ModelSubdivision
{
    public abstract class Building
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public char? Index { get; set; }
    }
}