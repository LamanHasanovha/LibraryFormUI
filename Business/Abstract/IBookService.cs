using Entities.Concrete;
using Entities.Models.ResponseModels;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookService : IServiceRepository<Book>
    {
        List<BookResponseModel> GetBooks();
        List<Book> GetByAuthor(int authorId);
        BookResponseModel GetRandomBook();
        BookResponseModel GetBookById(int bookId);
    }
}
