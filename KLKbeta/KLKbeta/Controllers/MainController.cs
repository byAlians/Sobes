using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KLKbeta.DependencyInjection.Release;
using KLKbeta.DependencyInjection;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Controllers
{
    public class MainController : Controller
    {
        IRepository<Staff> db;

        public MainController()
        {
            db = new SQLStaffRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Staff()
        {
            return View(db.GetList());
        }
    }
}