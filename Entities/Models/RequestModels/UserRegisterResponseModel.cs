using Entities.Concrete;
using Entities.Models.ResponseModels;

namespace Entities.Models.RequestModels
{
    public class UserRegisterResponseModel
    {
        public UserRegisterResponseModel()
        {

        }
        public UserRegisterResponseModel(User loggedUser, AccessToken accessToken)
        {
            RegisteredUser = loggedUser;
            AccessToken = accessToken;
        }
        public User RegisteredUser { get; set; }
        public AccessToken AccessToken { get; set; }
    }
}
