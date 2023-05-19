using Entities.Concrete;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookFavListService : IServiceRepository<BookFavList>
    {
        List<BookResponseModel> GetByAccount(int accountId);
        void RemoveByAccount(int accountId, int bookId);
    }
}
