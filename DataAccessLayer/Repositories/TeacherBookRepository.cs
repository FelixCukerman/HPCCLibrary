using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    class TeacherBookRepository : GenericRepository<TeacherBook>, ITeacherBookRepository
    {
        public TeacherBookRepository(LibraryContext context) : base(context)
        {
        }
    }
}
