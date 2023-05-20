using Entities.Concrete;
using Entities.Constants;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRatingService : IServiceRepository<Rating>
    {
        List<Rating> GetByRecord(int recordId, RatingTypes type);
        void SaveRating(Rating rating);
    }
}
