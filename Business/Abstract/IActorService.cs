using Entities.Concrete;

namespace Business.Abstract
{
    public interface IActorService : IServiceRepository<Actor>
    {
        Actor GetRandomActor();
    }
}
