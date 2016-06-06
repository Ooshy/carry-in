using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Register
{
    public interface RegisterService
    {
        bool Register();
        Task<bool> RegisterAsync();

        bool Registered { get; }
    }
}
