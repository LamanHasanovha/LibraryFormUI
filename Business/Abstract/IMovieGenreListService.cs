using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMovieGenreListService : IServiceRepository<MovieGenreList>
    {
        void DeleteByMovie(int recordId);
        List<MovieGenreList> GetByMovie(int recordId);
        List<MovieGenreList> UpdateByMovie(List<MovieGenreList> list);
    }
}
