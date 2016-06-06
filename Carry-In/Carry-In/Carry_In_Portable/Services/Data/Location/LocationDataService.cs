using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Data.Location
{
    public interface LocationDataService
    {
        IEnumerable<Model.Location> Locations();
        IEnumerable<Model.Location> Locations(long id);
    }
}
