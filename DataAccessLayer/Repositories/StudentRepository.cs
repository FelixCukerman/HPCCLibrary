using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<Student> GetByName(string name, string surname)
        {
            return await _data.Students.FirstOrDefaultAsync(item => item.Name == name && item.Surname == surname);
        }
    }
}
