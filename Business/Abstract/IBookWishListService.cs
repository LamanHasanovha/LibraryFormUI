using Entities.Concrete;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookWishListService : IServiceRepository<BookWishList>
    {
        List<BookResponseModel> GetByAccount(int accountId);
        void RemoveByAccount(int accountId, int bookId);
    }
}
