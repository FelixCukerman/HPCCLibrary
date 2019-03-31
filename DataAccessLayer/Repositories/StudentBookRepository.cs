using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentBookRepository : GenericRepository<StudentBook>, IStudentBookRepository
    {
        public StudentBookRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<List<StudentBook>> GetByUser(int userId)
        {
            return await _data.StudentBooks.Where(item => item.StudentId == userId).ToListAsync();
        }
    }
}
