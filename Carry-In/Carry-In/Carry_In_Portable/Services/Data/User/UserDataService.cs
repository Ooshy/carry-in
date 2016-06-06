using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Data.User
{
    public interface UserDataService
    {
        Model.User.User User(long id);       
    }
}
