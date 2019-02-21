using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class GroupeRepository : GenericRepository<Groupe>, IGroupeRepository
    {
        public GroupeRepository(LibraryContext context) : base(context)
        {
        }
    }
}
