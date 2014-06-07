using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contract;
using Domain;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json.Schema;
using PowerGridMVC.Models;

namespace PowerGridMVC.Controllers
{
    public class DistiGridController : Controller
    {
        private IGeoRepository _geoRepository;
        private IAreaRepository _areaRepository;
        private ISubsidiaryRepository _subsidiaryRepository;

        public DistiGridController(IGeoRepository geoRepository, IAreaRepository areaRepository,ISubsidiaryRepository subsidiaryRepository)
        {
            _geoRepository = geoRepository;
            _areaRepository = areaRepository;
            _subsidiaryRepository = subsidiaryRepository;
        }
        // GET: /DistiGrid/
        public ActionResult Index()
        {
            var distiGridModel=new DistiGridModel();
            return View("Index",distiGridModel);
        }

        public JsonResult GetCascadeCategories()
        {
            var geos = _geoRepository.All();
            return Json(geos.Select(c => new { Id = c.Id, Name = c.Name }), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAreaByGeo(int id)
        {
            var areas = _areaRepository.AreaByGeo(id).Where(x => x.GeoId==id);

            return Json(areas.Select(p => new { Id = p.Id, Name = p.Name}), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubsdiaryByArea(int areaId)
        {
            var subsidiaries = _subsidiaryRepository.SubsidiaryByArea(areaId).Where(x => x.AreaId==areaId);

            return Json(subsidiaries.Select(p => new { Id = p.Id, Name = p.Name }), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Load()
        {
            return View();
        }
        // public ActionResult Editing_Read([DataSourceRequest] DataSourceRequest request)
        //{
        //    //run the appropriate sql to get all the distributors for that cell
        //     var sqlcommand = "select * from dstsalesl100"; //TODO: change this sql once schema is ready
             
        //     using (SqlConnection connection = new SqlConnection("Data Source=110LAP279;Initial Catalog=PartnerGrid;Integrated Security=True;"))
        //     {
        //         using (SqlCommand command = new SqlCommand("select Id,Name from Geo", connection))
        //         {
        //             connection.Open();
        //             SqlDataReader reader = command.ExecuteReader();
        //             while (reader.Read())
        //             {
        //                 //read the required fields
        //             }

        //         }
        //     }

        //     return null;
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Editing_Create([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AccountModel> distributors)
        //{
        //    var results = new List<AccountModel>();

        //    if (distributors != null && ModelState.IsValid)
        //    {
        //        foreach (var distributor in distributors)
        //        {
        //            productService.Create(distributor);
        //            results.Add(distributor);
        //        }
        //    }

        //    return Json(results.ToDataSourceResult(request, ModelState));
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Editing_Update([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AccountModel> distributors)
        //{
        //    if (distributors != null && ModelState.IsValid)
        //    {
        //   foreach (var distributor in distributors)
        //        {
        //            productService.Update(distributor);
        //        }
        //    }

        //    return Json(distributors.ToDataSourceResult(request, ModelState));
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Editing_Destroy([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<AccountModel> distributors)
        //{            
        //    if (distributors.Any())
        //    {
        //        foreach (var product in distributors)
        //        {
        //            productService.Destroy(product);
        //        }
        //    }

        //    return Json(distributors.ToDataSourceResult(request,ModelState));
        //}
    }
}
    
