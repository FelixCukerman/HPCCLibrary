using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IStudentBookRepository : IRepository<StudentBook>
    {
        Task<List<StudentBook>> GetByUser(int userId);
    }
}
