using Entities.Concrete;
using Entities.Models.RequestModels;

namespace Business.Abstract
{
    public interface IAccountService : IServiceRepository<Account>
    {
        Account Login(AccountLoginModel model);
        Account Register(AccountRegisterModel model);
        Account UpdateWithPassword(AccountUpdateModel model);
        Account UpdateInfo(AccountUpdateInfoModel model);
        bool CheckPass(string username, string password);
    }
}
