
using Carry_In.Pages.Register.Models;
using System.Threading.Tasks;
using System;
using Carry_In.Models;

namespace Carry_In.Register
{
    public class RegisterViewModel
    {

        public RegisterViewModel()
        {
            RegisterModel = new RegisterModel();
            CarryInModel = new CarryInModel(RegisterModel);
        }

        public CarryInModel CarryInModel { get; set; }
        public RegisterModel RegisterModel { get; set; }
        public async Task<bool> Register()
        {
            if (Validate())
            {
                if (!UserExists())
                    return AddUser();
            }

            return false;
        }

        private bool UserExists()
        {
            return App.Database.UserExists(RegisterModel.Email);
        }

        private bool AddUser()
        {
            return App.Database.SaveUser(CarryInModel) > 0;
        }

        private bool Validate()
        {
            var address = ValidateAddress();
            var email = ValidateEmail();
            var name = ValidateName();

            if (address && email && name)
                return true;
            return false;
        }

        private bool ValidateName()
        {
            
            if (String.IsNullOrEmpty(RegisterModel.FirstName) ||
                String.IsNullOrEmpty(RegisterModel.LastName))
            {
                return false;
            }

            return true;
        }

        private bool ValidateEmail()
        {
            return true; //TODO
        }

        private bool ValidateAddress()
        {
            return true; //TODO?
        }
    }
}
