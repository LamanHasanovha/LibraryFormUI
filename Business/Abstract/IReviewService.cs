using Entities.Concrete;
using Entities.Constants;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReviewService : IServiceRepository<Review>
    {
        List<ReviewResponseModel> GetByType(int recordId, RatingTypes type);
    }
}
