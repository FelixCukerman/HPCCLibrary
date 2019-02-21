using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(LibraryContext context) : base(context)
        {
        }
    }
}
