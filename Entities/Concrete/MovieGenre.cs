using Entities.Abstract;

namespace Entities.Concrete
{
    public class MovieGenre : IEntity
    {
        public MovieGenre() { }

        public MovieGenre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
