using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(LibraryContext context) : base(context)
        {
        }
    }
}
