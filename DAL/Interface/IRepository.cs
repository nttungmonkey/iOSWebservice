using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepository<T>
    {
        Task<T> Create(T _object);

        void Update(T _object);

        IEnumerable<T> GetAll();

        T GetById(int Id);

        void Delete(T _object);
    }
}
