using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using AutoMapper;
using BusinessLogicLayer.ViewModels;

namespace BusinessLogicLayer.Services
{
    public class LibraryService : ILibraryService
    {
        private IBookRepository bookRepository;
        private IGenreRepository genreRepository;
        private IGroupeRepository groupeRepository;
        private IStudentRepository studentRepository;
        private IStudentBookRepository studentBookRepository;
        private ISubjectRepository subjectRepository;
        private IMapper mapper;

        public LibraryService(IBookRepository bookRepository, IGenreRepository genreRepository, IGroupeRepository groupeRepository, IStudentRepository studentRepository, IStudentBookRepository studentBookRepository, ISubjectRepository subjectRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.genreRepository = genreRepository;
            this.groupeRepository = groupeRepository;
            this.studentRepository = studentRepository;
            this.studentBookRepository = studentBookRepository;
            this.subjectRepository = subjectRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Genre>> GetAllGenre()
        {
            var result = await genreRepository.Get();
            return result;
        }

        public async Task CreateBook(CreateBookViewModel request)
        {
            Book bookToCreate = mapper.Map<Book>(request);
            await bookRepository.Create(bookToCreate);
        }

        public async Task<List<Book>> GetBooksByGenre(string genreTitle)
        {
            Genre genre = await genreRepository.GetGenreByTitle(genreTitle);
            List<Book> books = await bookRepository.GetBooksByGenre(genre.Id);

            return books;
        }

        public async Task<List<Book>> GetBooksByAuthor(string author)
        {
            List<Book> books = await bookRepository.GetBooksByAuthor(author);

            return books;
        }

        public async Task<List<Book>> GetBooksByLanguage(string language)
        {
            List<Book> books = await bookRepository.GetBooksByLanguage(language);

            return books;
        }

        public async Task AddBookToFavorites(AddBookToFavoritesViewModel request)
        {
            Book book = await bookRepository.GetByTitle(request.Booktitle);
            Student user = await studentRepository.GetByName(request.Name, request.Surname);

            StudentBook createRequest = new StudentBook { BookId = book.Id, StudentId = user.Id };

            await studentBookRepository.Create(createRequest);
        }

        public async Task<List<StudentBook>> GetFavoriteBooks(int studentId)
        {
            List<StudentBook> result = await studentBookRepository.GetByUser(studentId);

            return result;
        }
    }
}
