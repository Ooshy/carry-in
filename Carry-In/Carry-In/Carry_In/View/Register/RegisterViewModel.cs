
using Carry_In.View.Register.Models;
using System.Threading.Tasks;
using System;


namespace Carry_In.Register
{
    public class RegisterViewModel
    {

        public RegisterViewModel()
        {
            RegisterModel = new RegisterModel();
        }

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
            return /*App.Database.UserExists(RegisterModel.Email);*/ true;
        }

        private bool AddUser()
        {
            return /*App.Database.SaveUser(RegisterModel) > 0;*/ true;
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
