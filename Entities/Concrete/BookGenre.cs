using Entities.Abstract;

namespace Entities.Concrete
{
    public class BookGenre : IEntity
    {
        public BookGenre() { }

        public BookGenre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
