using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task<Genre> GetGenreByTitle(string title);
    }
}
