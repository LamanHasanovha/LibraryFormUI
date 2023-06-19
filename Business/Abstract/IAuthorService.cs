using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAuthorService : IServiceRepository<Author>
    {
        Author GetRandomAuthor();
    }
}
