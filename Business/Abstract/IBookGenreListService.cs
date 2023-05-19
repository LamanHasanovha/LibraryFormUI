using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookGenreListService : IServiceRepository<BookGenreList>
    {
        void DeleteByBook(int recordId);
        List<BookGenreList> GetByBook(int recordId);
        List<BookGenreList> UpdateByBook(List<BookGenreList> list);
    }
}
