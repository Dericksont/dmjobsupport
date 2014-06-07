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
    public class SubsidiaryRepository:ISubsidiaryRepository
    
    {
        private IList<Subsidiary> _subsidiaries;

        public SubsidiaryRepository(IList<Subsidiary> subsidiaries)
        {
            _subsidiaries = subsidiaries;
        }

        public IList<Subsidiary> All()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DERICK\SQLEXPRESS;Initial Catalog=PartnerGrid;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand("select Id, Name, AreaId from Subsidiary", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        _subsidiaries.Add(new Subsidiary()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString(),
                            AreaId=Convert.ToInt32(reader.GetValue(2).ToString())
                        });
                    }

                }
            }
            return _subsidiaries;
        }



        public IList<Subsidiary> SubsidiaryByArea(int areaId)
        {
            return All().Where(x=>x.AreaId==areaId).ToList();
        }
    }
}

