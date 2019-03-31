using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetByTitle(string title);
        Task<List<Book>> GetBooksByGenre(int genreId);
        Task<List<Book>> GetBooksByAuthor(string authorName);
        Task<List<Book>> GetBooksByLanguage(string language);
    }
}
