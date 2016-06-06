using Carry_In.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Data.Food
{
    public interface FoodDataService
    {
        IEnumerable<Model.Food> Foods();
        IEnumerable<Model.Food> Foods(long id);
    }
}
