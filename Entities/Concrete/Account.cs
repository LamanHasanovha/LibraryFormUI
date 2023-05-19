using Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Account : IEntity
    {
        public Account() { }

        public Account(int id, string firstName, string lastName, string username, string email, byte[] passwordHash, byte[] passwordSalt, DateTime lastLoginDate, bool status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            LastLoginDate = lastLoginDate;
            Status = status;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool Status { get; set; }
    }
}
