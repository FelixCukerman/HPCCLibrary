using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<Teacher> GetByName(string name, string surname)
        {
            return await _data.Teachers.FirstOrDefaultAsync(item => item.Name == name && item.Surname == surname);
        }
    }
}
