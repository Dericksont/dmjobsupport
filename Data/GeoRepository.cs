using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Domain;
using System.Data.SqlClient;

namespace Data
{
    public class GeoRepository:IGeoRepository
    {
        private IList<Geo> _geos;

        public GeoRepository(IList<Geo> geos)
        {
            _geos = geos;
        }

        public IList<Geo> All()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DERICK\SQLEXPRESS;Initial Catalog=PartnerGrid;Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand("select Id,Name from Geo", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        _geos.Add(new Geo()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString()
                        }
                        );
                    }

                }
            }
            return _geos;
        }
    }
} 
