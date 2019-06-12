using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KLKbeta.Models.ModelForDB.ModelPeople;


namespace KLKbeta.Models.ModelForDB.ModelDataTable
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int WorkTimeId { get; set; }
        public WorkTime WorkTime { get; set; }
        

        public ICollection<Staff> Staffs { get; set; }
        public Schedule()
        {
            Staffs = new List<Staff>();
        }
    }
}