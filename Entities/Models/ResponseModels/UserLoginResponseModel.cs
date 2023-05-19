using Entities.Abstract;
using Entities.Concrete;

namespace Entities.Models.ResponseModels
{
    public class UserLoginResponseModel : IModel
    {
        public UserLoginResponseModel()
        {

        }
        public UserLoginResponseModel(User loggedUser, AccessToken accessToken)
        {
            LoggedUser = loggedUser;
            AccessToken = accessToken;
        }
        public User LoggedUser { get; set; }
        public AccessToken AccessToken { get; set; }
    }
}
