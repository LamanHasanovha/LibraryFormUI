using Entities.Concrete;
using Entities.Constants;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICartService : IServiceRepository<Cart>
    {
        bool Check(int accountId, int recordId, ProductTypes type);
        List<CartResponseModel> GetByAccount(int id);
        void RemoveByAccount(int accountId, int recordId, ProductTypes type);
    }
}
