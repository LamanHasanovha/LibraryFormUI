using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAuthCodeService : IServiceRepository<AuthCode>
    {
        void SendAuthCode(int accountId);
        bool CheckAuthCode(int accountId, string code);
    }
}
