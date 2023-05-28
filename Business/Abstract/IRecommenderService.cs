using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRecommenderService
    {
        List<Movie> GetMoviesByAccount(int accountId, int count);
        List<Movie> GetMovies(int movieId, int count);
        List<Book> GetBooksByAccount(int accountId, int count);
        List<Book> GetBooks(int bookId, int count);
    }
}
