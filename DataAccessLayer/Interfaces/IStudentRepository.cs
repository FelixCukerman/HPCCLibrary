using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetByName(string name, string surname);
    }
}
