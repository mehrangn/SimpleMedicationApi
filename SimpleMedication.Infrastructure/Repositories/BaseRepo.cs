using Microsoft.EntityFrameworkCore;
using SimpleMedication.Application.Contracts.Persistance;
using SimpleMedication.Domain.Common;
using SimpleMedication.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Infrastructure.Repositories
{
    public class BaseRepo<T> : IGenericRepo<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext _dbContext;

        public BaseRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
