using EntitiesLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<Book> GetByTitle(string title)
        {
            return await _data.Books.FirstOrDefaultAsync(item => item.Title == title);
        }

        public async Task<List<Book>> GetBooksByGenre(int genreId)
        {
            return await _data.Books.Where(item => item.GenreId == genreId).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByAuthor(string authorName)
        {
            return await _data.Books.Where(item => item.Author == authorName).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByLanguage(string language)
        {
            return await _data.Books.Where(item => item.Language == language).ToListAsync();
        }
    }
}
