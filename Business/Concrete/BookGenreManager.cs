using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System.Net.Http;

namespace Business.Concrete
{
    public class BookGenreManager : ManagerBaseRepository<BookGenre>, IBookGenreService
    {
        public BookGenreManager(HttpClient client, string baseAddress, UserForLoginModel user) : base(client, baseAddress, user)
        {
        }
    }
}
