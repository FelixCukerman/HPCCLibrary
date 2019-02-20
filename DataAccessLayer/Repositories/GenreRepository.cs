using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private LibraryContext _context;
        public GenreRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Genre>> Get()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task<Genre> Get(int id)
        {
            return await _context.Genres.FirstOrDefaultAsync(genre => genre.Id == id);
        }

        public async Task Create(Genre genre)
        {
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();
        }
    }
}
