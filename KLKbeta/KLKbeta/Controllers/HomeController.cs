using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KLKbeta.Models.ModelForDB.ModelDataTable;
using KLKbeta.DependencyInjection.Release;
using KLKbeta.DependencyInjection;
using KLKbeta.Models.Count;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Fact> db;
        IRepository<Staff> dbStaff;
        public HomeController()
        {
            db = new SQLTableRepository();
            dbStaff = new SQLStaffRepository();

        }

        public ActionResult DataTable()
        {
            CountDays Cdays=new CountDays();
            ViewBag.CDays=Cdays.CountDaysInMonth(2019, 2);
            ViewBag.Staff = dbStaff.GetList();

          return  View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

}