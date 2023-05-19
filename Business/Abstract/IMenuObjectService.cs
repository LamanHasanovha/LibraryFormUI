using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMenuObjectService : IServiceRepository<MenuObject>
    {
        List<MenuObject> GetByContent(int contentId);
    }
}
