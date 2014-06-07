using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerGridMVC.Models
{
    public class EachAccountModel
    {
        public string GlobalParentName { get; set; }

        public string Tpid { get; set; }

        public int AccountId { get; set; }
        public string DeviceIb { get; set; }
        public string PcibMal { get; set; }
        public string PcibWindows { get; set; }
        public string PcibOffice { get; set; }
        public string Am { get; set; }
        public string Ats { get; set; }
        public string Atu { get; set; }
        public string Subsidary { get; set; }
        public string Industry { get; set; }
        public string SubSegment { get; set; }
        public string IncludeInEaf { get; set; }
        public string EmployeeCount { get; set; }

        public int RAccountId { get; set; }

        public string RPartnerName { get; set; }
        public string Indicator1 { get; set; }
        public string Indicator2 { get; set; }
        public string Indicator3 { get; set; }
        public string Indicator4 { get; set; }
        public string Indicator5 { get; set; }
        public string Indicator6 { get; set; }
        public string Indicator7 { get; set; }
        public string Indicator8 { get; set; }

    }
}