using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPCCLibrary.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private ILibraryService libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        [HttpGet]
        [Route("getallgenre")]
        public async Task<IEnumerable<Genre>> GetAllGenre()
        {
            return await libraryService.GetAllGenre();
        }

        [HttpGet]
        [Route("createbook")]
        public async Task CreateBook(CreateBookViewModel request)
        {
            await libraryService.CreateBook(request);
        }

        [HttpGet]
        [Route("creategenre/{name}/{description}")]
        public async Task CreateGenre(string name, string description)
        {
            await libraryService.CreateGenre(name, description);
        }

        [HttpGet]
        [Route("bygenre/{genreTitle}")]
        public async Task<List<Book>> GetBooksByGenre(string genreTitle)
        {
            return await libraryService.GetBooksByGenre(genreTitle);
        }

        [HttpGet]
        [Route("byauthor/{author}")]
        public async Task<List<Book>> GetBooksByAuthor(string author)
        {
            return await libraryService.GetBooksByAuthor(author);
        }

        [HttpGet]
        [Route("bylanguage/{language}")]
        public async Task<List<Book>> GetBooksByLanguage(string language)
        {
            return await libraryService.GetBooksByLanguage(language);
        }

        [HttpGet]
        [Route("booktofavorites")]
        public async Task AddBookToFavorites(AddBookToFavoritesViewModel request)
        {
            await libraryService.AddBookToFavorites(request);
        }

        [HttpGet]
        [Route("addteacherbook")]
        public async Task AddTeacherBook(AddBookToFavoritesViewModel request)
        {
            await libraryService.AddTeacherBook(request);
        }
        
        [HttpGet]
        [Route("favoritebooks")]
        public async Task<List<StudentBook>> GetFavoriteBooks(int studentId)
        {
            return await libraryService.GetFavoriteBooks(studentId);
        }
        
        [HttpGet]
        [Route("deletefavoritebooks/{studentId}/{bookId}")]
        public async Task DeleteFavoriteBook(int studentId, int bookId)
        {
            await libraryService.DeleteFavoriteBook(studentId, bookId);
        }

        [HttpGet]
        [Route("teacherbooks/{teacherId}")]
        public async Task<IEnumerable<TeacherBook>> GetTeacherBooks(int teacherId)
        {
            return await libraryService.GetTeacherBooks(teacherId);
        }

        [HttpGet]
        [Route("deleteteacherbooks/{teacherId}/{bookId}")]
        public async Task DeleteTeacherBook(int teacherId, int bookId)
        {
            await libraryService.DeleteTeacherBook(teacherId, bookId);
        }
        
        [HttpGet]
        [Route("allbooks")]
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await libraryService.GetAllBooks();
        }

        [HttpGet]
        [Route("allgenres")]
        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await libraryService.GetAllGenre();
        }

        
        [HttpGet]
        [Route("bysubject/{subjectName}")]
        public async Task<IEnumerable<Book>> GetBooksBySubject(string subjectName)
        {
            return await libraryService.GetBooksBySubject(subjectName);
        }
    }
}
