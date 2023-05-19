using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMovieActorService : IServiceRepository<MovieActor>
    {
        void DeleteByMovie(int recordId);
        List<MovieActor> GetByMovie(int recordId);
        List<MovieActor> UpdateByMovie(List<MovieActor> list);
    }
}
