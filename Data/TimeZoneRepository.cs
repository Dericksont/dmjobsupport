using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Domain;

namespace Data
{
    public class TimeZoneRepository: ITimeZoneRepository
    {
        private IList<Timezone> _timeZones;

        public TimeZoneRepository(IList<Timezone> timeZones)
        {
            _timeZones = timeZones;
        }

        public IList<Timezone> All()
        {
            //using (SqlConnection connection = new SqlConnection("Data Source=110LAP279;Initial Catalog=PartnerGrid;Integrated Security=True;"))
            //{
            //    using (SqlCommand command = new SqlCommand("select distinct(Geo) from AreaMap", connection))
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            _timeZones.Add(new Timezone()
            //            {
            //                Geo= reader.GetValue(0).ToString(),
            //                //Area = reader.GetValue(1).ToString(),
            //                //Subsidiary = reader.GetValue(2).ToString()

            //            });
            //        }

            //    }
            //}
            _timeZones = new[]
            {
                new Timezone(){Geo = "Americas",Area = "Americas",Subsidiary = "America"},
                new Timezone(){Geo = "Canada",Area = "Canada",Subsidiary = "Canada"}
            };
                               
            return _timeZones;
        }

        public IList<Timezone> AreaByGeo(string tzName)
        {
            return All().Where(x => x.Geo == tzName).ToList();
        }

        public IList<Timezone> SubsidiaryByArea(string areaName)
        {
            return All().Where(x => x.Area == areaName).ToList();
        }
    }
}
