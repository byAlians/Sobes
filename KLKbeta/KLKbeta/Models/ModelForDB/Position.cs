using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Models.ModelForDB
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionStaff { get; set; }

        public ICollection<Staff> Staff { get; set; }

        public Position()
        {
            Staff = new List<Staff>();
        }
    }
}