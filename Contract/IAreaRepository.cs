using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Contract
{
    public interface IAreaRepository
    {
        IList<Area>All();

        IList<Area> AreaByGeo(int id);

    }
}
