using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMedication.Domain.Common;
using SimpleMedication.Domain.Entities;

namespace SimpleMedication.Application.Contracts.Persistance
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
    }
}
