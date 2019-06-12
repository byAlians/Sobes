using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KLKbeta.Models.ModelForDB.ModelSubdivision;
using KLKbeta.Models.ModelForDB.ModelDataTable;

namespace KLKbeta.Models.ModelForDB.ModelPeople
{
    public class Staff:People
    {
        public int PersonnelNo { get; set; }

        public int TypeOfEmployeeId { get; set; }
        public TypeOfEmployee TypeOfEmployee { get; set; }


        public int SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }


        public int PositionId { get; set; }
        public Position Position { get; set; }

        public ICollection<Fact> Fact { get; set; }
        public ICollection<Schedule> Schedule { get; set; }

        public Staff()
        {
            Fact = new List<Fact>();
            Schedule = new List<Schedule>();
        }
    }
}