using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLKbeta.Models.Count
{
    public class CountDays
    {
        private DateTime dateTime;
        private ICollection<string> daysInMonth;

        public ICollection<string> CountDaysInMonth(int year, int month)
        {
            daysInMonth = new List<string>();
            dateTime = new DateTime(year, month, 1);
            while (dateTime.Month == month)
            {
                daysInMonth.Add(dateTime.ToString("d"));
                dateTime = dateTime.AddDays(1);
            }
            return daysInMonth;
        }
    }
}