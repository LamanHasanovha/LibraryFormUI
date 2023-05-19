using Entities.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IServiceRepository<T> where T : class, IEntity, new()
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        void DeleteAll();
        List<T> GetAll();
        T Get(int id);
    }
}
