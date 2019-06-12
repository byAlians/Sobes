using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLKbeta.Models.ModelForDB.ModelSubdivision
{
    public class Subdivision:Building
    {
        public int SubdivisionNumber { get; set; }
        public string NameSubdivision { get; set; }
    }
}