using Entities.Abstract;

namespace Entities.Models.RequestModels
{
    public class UserForLoginModel : IModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
