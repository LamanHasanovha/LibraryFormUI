using Entities.Abstract;

namespace Entities.Models.RequestModels
{
    public class AccountUpdateModel : IModel
    {
        public AccountUpdateModel() { }

        public AccountUpdateModel(int id, string firstName, string lastName, string username, string password, bool status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Status = status;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
