using Entities.Concrete;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMovieService : IServiceRepository<Movie>
    {
        List<MovieResponseModel> GetMovies();
        MovieResponseModel GetRandomMovie();
        List<Movie> GetByActor(int  actorId);
        List<Movie> GetByDirector(int directorId);
        MovieResponseModel GetMovieById(int movieId);
        string GetMaxMinValues();
        List<MovieResponseModel> GetPopularMovies();
    }
}
