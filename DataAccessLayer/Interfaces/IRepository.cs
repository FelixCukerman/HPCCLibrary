using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id);
        Task Create(T item);
        Task Update(T item);
        Task Delete(T t);
    }
}
