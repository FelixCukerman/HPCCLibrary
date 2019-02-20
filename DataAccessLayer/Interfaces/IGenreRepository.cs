using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<Genre>> Get();
        Task<Genre> Get(int id);
        Task Create(Genre item);
    }
}
