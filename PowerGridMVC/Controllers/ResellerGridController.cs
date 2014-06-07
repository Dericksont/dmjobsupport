using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contract;
using PowerGridMVC.Models;

namespace PowerGridMVC.Controllers
{
    public class ResellerGridController : Controller
    {
        private ITimeZoneRepository _timeZoneRepository;

        public ResellerGridController(ITimeZoneRepository timeZoneRepository )
        {
            _timeZoneRepository = timeZoneRepository;
        }
        //
        // GET: /ResellerGrid/
        public ActionResult Index()
        {
            var resellerGridModel = new ResellerGridModel();
            return View("Index", resellerGridModel);
            
        }
        public JsonResult GetCascadeCategories()
        {
            var geos = _timeZoneRepository.All();
            return Json(geos.Select(c => new { Geo=c.Geo}), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAreaByGeo(string Name)
        {
            var areas = _timeZoneRepository.AreaByGeo(Name).Where(x => x.Geo == Name);

            return Json(areas.Select(p => new { Area = p.Area }), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubsdiaryByArea(string areaName)
        {
            var subsidiaries = _timeZoneRepository.SubsidiaryByArea(areaName).Where(x => x.Area == areaName);

            return Json(subsidiaries.Select(p => new {Subsidiary = p.Subsidiary }), JsonRequestBehavior.AllowGet);
        }

	}
}