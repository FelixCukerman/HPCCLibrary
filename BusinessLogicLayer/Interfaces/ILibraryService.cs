using BusinessLogicLayer.ViewModels;
using EntitiesLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ILibraryService
    {
        Task<IEnumerable<Genre>> GetAllGenre();
        Task CreateBook(CreateBookViewModel book);
        Task CreateGenre(string name, string description);
        Task<List<Book>> GetBooksByGenre(string genreTitle);
        Task<List<Book>> GetBooksByAuthor(string author);
        Task<List<Book>> GetBooksByLanguage(string language);
        Task AddBookToFavorites(AddBookToFavoritesViewModel request);
        Task AddTeacherBook(AddBookToFavoritesViewModel request);
        Task<List<StudentBook>> GetFavoriteBooks(int studentId);
        Task DeleteFavoriteBook(int studentId, int bookId);
        Task<IEnumerable<TeacherBook>> GetTeacherBooks(int teacherId);
        Task DeleteTeacherBook(int teacherId, int bookId);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<IEnumerable<Genre>> GetAllGenres();
        Task<IEnumerable<Book>> GetBooksBySubject(string subjectName);
    }
}
