using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System.Net.Http;

namespace Business.Concrete
{
    public class DirectorManager : ManagerBaseRepository<Director>, IDirectorService
    {
        public DirectorManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }
    }
}
