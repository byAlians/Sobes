using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KLKbeta.Models.ModelForDB.ModelPeople;
using KLKbeta.Models.ModelForDB.ModelSubdivision;
using KLKbeta.Models.ModelForDB.ModelDataTable;

namespace KLKbeta.Models.ModelForDB.ContextFile
{
    public class ContextKLK:DbContext
    {
        public ContextKLK()
            : base("DbConnection")
        { }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}