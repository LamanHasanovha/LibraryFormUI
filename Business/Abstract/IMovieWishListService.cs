using Entities.Concrete;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMovieWishListService : IServiceRepository<MovieWishList>
    {
        List<MovieResponseModel> GetByAccount(int accountId);
        void RemoveByAccount(int accountId, int movieId);
    }
}
