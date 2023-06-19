using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDirectorService : IServiceRepository<Director>
    {
        Director GetRandomDirector();
    }
}
