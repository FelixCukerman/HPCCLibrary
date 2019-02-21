using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class StudentBookRepository : GenericRepository<StudentBook>, IStudentBookRepository
    {
        public StudentBookRepository(LibraryContext context) : base(context)
        {
        }
    }
}
