using Carry_In.Pages.Register.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carry_In.Models
{
    public class CarryInModel
    {
        public RegisterModel RegistrationInfo { get; set; }
        public CarryInModel(RegisterModel registrationInfo)
        {
            RegistrationInfo = registrationInfo;
        }
    }
}
