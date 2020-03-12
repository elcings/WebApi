using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreApi.Contract.Factories
{
    public interface IEntityFactory<T>
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetByIdAsync(Guid Id);
        Task<bool> RemoveAsync(Guid Id);
        Task<ICollection<T>> GetAllAsync();
    }
}
