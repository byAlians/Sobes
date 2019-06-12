using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KLKbeta.Models.ModelForDB.ModelDataTable;

namespace KLKbeta.Models.ModelForDB
{
    public class WorkTime
    {
        public int Id { get; set; }

        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public string TimeWorking { get; set; }

        public ICollection<Schedule> Schedules { get; set; }

        public WorkTime()
        {
            Schedules = new List<Schedule>();
        }
    }
}