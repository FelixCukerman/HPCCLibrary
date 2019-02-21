using DataAccessLayer.Interfaces;
using EntitiesLayer.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected LibraryContext _data;
        private DbSet<T> _dbSet;
        public GenericRepository(LibraryContext _data)
        {
            this._data = _data;
            _dbSet = _data.Set<T>();
        }
        public async Task<IEnumerable<T>> Get()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        public async Task<T> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task Create(T t)
        {
            _dbSet.Add(t);
            await _data.SaveChangesAsync();
        }
        public async Task Update(T t)
        {
            _data.Entry(t).State = EntityState.Modified;
            await _data.SaveChangesAsync();
        }
        public async Task Delete(T t)
        {
            _dbSet.Remove(t);
            await _data.SaveChangesAsync();
        }
    }
}
