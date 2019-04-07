using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Task<Teacher> GetByName(string name, string surname);
    }
}
