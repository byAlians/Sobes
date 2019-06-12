using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KLKbeta.Models.ModelForDB.ContextFile;
using KLKbeta.Models.ModelForDB.ModelPeople;

namespace KLKbeta.Controllers
{
    public class HomeController : Controller
    {
        ContextKLK db = new ContextKLK();
        public ActionResult ViewAddStaff()
        {
            IEnumerable<SelectListItem> getTypeOfEmployee = new SelectList(db.TypeOfEmployees.AsEnumerable(), "Id", "NameType");
            IEnumerable<SelectListItem> getSubdivision = new SelectList(db.Subdivisions.AsEnumerable(), "Id", "NameSubdivision");
            IEnumerable<SelectListItem> getPosition = new SelectList(db.Positions.AsEnumerable(), "Id", "PositionStaff");
            ViewBag.Position = getPosition;
            ViewBag.TypeOfEmployee = getTypeOfEmployee;
            ViewBag.Subdivision = getSubdivision;
            return View(new Staff());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(Staff staffs)
        {
            using (ContextKLK db = new ContextKLK())
            {
                Staff staff = staffs;
                db.Staffs.Add(staff);
                db.SaveChanges();

            }
            return RedirectToAction("About");
        }
    }
}