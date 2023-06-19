using Entities.Concrete;
using Entities.Constants;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReviewService : IServiceRepository<Review>
    {
        Review GetByAccount(int id, int recordId, RatingTypes type);
        List<ReviewResponseModel> GetByType(int recordId, RatingTypes type);
    }
}
