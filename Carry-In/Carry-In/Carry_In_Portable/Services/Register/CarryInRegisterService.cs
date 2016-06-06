using System;
using System.Threading.Tasks;

namespace Carry_In.Services.Register
{
    public class CarryInRegisterService : RegisterService
    {
        private SystemServices _SystemServices { get; }
        public CarryInRegisterService(SystemServices systemServices)
        {
            _SystemServices = systemServices;
        }

        public bool Registered
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Register()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
