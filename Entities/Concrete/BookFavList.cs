using Entities.Abstract;

namespace Entities.Concrete
{
    public class BookFavList : IEntity
    {
        public BookFavList() { }

        public BookFavList(int id, int accountId, int bookId)
        {
            Id = id;
            AccountId = accountId;
            BookId = bookId;
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BookId { get; set; }
    }
}
