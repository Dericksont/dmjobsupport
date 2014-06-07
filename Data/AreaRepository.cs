using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Contract;
using Domain;

namespace Data
{
    public class AreaRepository: IAreaRepository
    {
        private IList<Area> _areas;

        public AreaRepository(IList<Area> areas)
        {
            _areas = areas;
        }

        public IList<Area> All()
        {
           
      
            using (SqlConnection connection = new SqlConnection(@"Data Source=DERICK\SQLEXPRESS;Initial Catalog=PartnerGrid;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand("select Id, Name, GeoId from Area", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        _areas.Add(new Area()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString(),
                            GeoId = Convert.ToInt32(reader.GetValue(2).ToString())

                        });
                    }

                }
            }
            return _areas;
        }



        public IList<Area> AreaByGeo(int id)
        {
            return All().Where(x => x.GeoId==id).ToList();
        }
    }
}
     