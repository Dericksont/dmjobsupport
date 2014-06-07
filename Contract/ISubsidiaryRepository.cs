using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Contract
{
    public interface ISubsidiaryRepository
    {
        IList<Subsidiary> All();

        IList<Subsidiary> SubsidiaryByArea(int areaId);
    }
}
