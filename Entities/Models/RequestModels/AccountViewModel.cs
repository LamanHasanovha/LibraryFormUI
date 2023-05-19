using System;

namespace Entities.Models.RequestModels
{
    public class AccountViewModel
    {
        public AccountViewModel() { }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool Status { get; set; }
    }
}
