using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Contract
{
    public interface ITimeZoneRepository
    {
        IList<Timezone> All();

        IList<Timezone> AreaByGeo(string tzName);

        IList<Timezone> SubsidiaryByArea(string areaName);
    }
}
