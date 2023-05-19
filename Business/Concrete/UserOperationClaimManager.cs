using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System.Net.Http;

namespace Business.Concrete
{
    public class UserOperationClaimManager : ManagerBaseRepository<UserOperationClaim>, IUserOperationClaimService
    {
        public UserOperationClaimManager(HttpClient client, string baseAddress, UserForLoginModel user) : base(client, baseAddress, user)
        {
        }
    }
}
