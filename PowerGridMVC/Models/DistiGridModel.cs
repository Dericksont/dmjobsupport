using System.Collections.Generic;
using System.Web.Mvc;
using Domain;

namespace PowerGridMVC.Models
{
    public class DistiGridModel
    {
        public Geo geo { get; set; }
        public IList<Geo> Geos { get; set; }
        public IList<Area> Areas { get; set; }
        public IList<Subsidiary> Subsidiaries { get; set; }
       
            //public IList<SelectListItem> Geos { get; set; }
            //public string SelectedGeo { get; set; }
        
    }



    
}