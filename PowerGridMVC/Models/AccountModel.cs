using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace PowerGridMVC.Models
{
    /// <summary>
    /// Data table that is common to DistiGrid and Reseller grid Account information
    /// </summary>
    public class AccountModel
    {
        public IList<SelectListItem> Distributor { get; set; }
    
        public int AccountId { get; set; }
        public string PartnerName { get; set; }
        
        //TODO: change these indicators to reflect actual indicators
        public string Indicator1 { get; set; }
        public string Indicator2 { get; set; }
        public string Indicator3 { get; set; }
        public string Indicator4 { get; set; }
        public string Indicator5 { get; set; }
        public string Indicator6 { get; set; }
        public string Indicator7 { get; set; }
        public string Indicator8 { get; set; }

    }

    //public class AccountDbContext : DbContext
    //{
    //    public DbSet<AccountModel> Accounts { get; set; }
    //}
}