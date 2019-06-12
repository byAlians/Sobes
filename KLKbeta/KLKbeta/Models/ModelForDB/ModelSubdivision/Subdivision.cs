﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Models.ModelForDB.ModelSubdivision
{
    public class Subdivision:Building
    {
        public int SubdivisionNumber { get; set; }
        public string NameSubdivision { get; set; }

        public ICollection<Staff> Staff { get; set; }

        public Subdivision()
        {
            Staff = new List<Staff>();
        }
    }
}