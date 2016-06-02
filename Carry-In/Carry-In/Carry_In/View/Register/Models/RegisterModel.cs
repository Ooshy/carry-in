

namespace Carry_In.Pages.Register.Models
{
    public class RegisterModel
    {        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; } // optional
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
