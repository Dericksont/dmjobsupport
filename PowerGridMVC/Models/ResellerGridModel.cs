using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace PowerGridMVC.Models
{
    public class ResellerGridModel
    {
        public Geo geo { get; set; }
        public IList<Geo> Geos { get; set; }
        public IList<Area> Areas { get; set; }
        public IList<Subsidiary> Subsidiaries { get; set; }
        //public IList<SelectListItem> Geo { get; set; }

        //public IList<SelectListItem> SWservices { get; set; }

        //public IList<SelectListItem> Devices { get; set; }

        //public IList<SelectListItem> Partners { get; set; }

    }
}