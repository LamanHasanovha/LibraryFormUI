using Entities.Abstract;

namespace Entities.Concrete
{
    public class MovieFavList : IEntity
    {
        public MovieFavList() { }

        public MovieFavList(int id, int accountId, int movieId)
        {
            Id = id;
            AccountId = accountId;
            MovieId = movieId;
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int MovieId { get; set; }
    }
}
