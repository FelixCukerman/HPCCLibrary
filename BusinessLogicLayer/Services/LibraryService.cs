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
using System.Linq;

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
        private ITeacherRepository teacherRepository;
        private ITeacherBookRepository teacherBookRepository;
        private IMapper mapper;

        public LibraryService(IBookRepository bookRepository, IGenreRepository genreRepository, IGroupeRepository groupeRepository, IStudentRepository studentRepository, IStudentBookRepository studentBookRepository, ISubjectRepository subjectRepository, ITeacherRepository teacherRepository, ITeacherBookRepository teacherBookRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.genreRepository = genreRepository;
            this.groupeRepository = groupeRepository;
            this.studentRepository = studentRepository;
            this.studentBookRepository = studentBookRepository;
            this.subjectRepository = subjectRepository;
            this.teacherRepository = teacherRepository;
            this.teacherBookRepository = teacherBookRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Genre>> GetAllGenre()
        {
            var result = await genreRepository.Get();
            return result;
        }

        public async Task CreateGenre(string name, string description)
        {
            Genre genre = new Genre { Title = name, Description = description };
            await genreRepository.Create(genre);
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

        public async Task AddTeacherBook(AddBookToFavoritesViewModel request)
        {
            Book book = await bookRepository.GetByTitle(request.Booktitle);
            Teacher user = await teacherRepository.GetByName(request.Name, request.Surname);

            TeacherBook createRequest = new TeacherBook { BookId = book.Id, TeacherId = user.Id };

            await teacherBookRepository.Create(createRequest);
        }

        public async Task<List<StudentBook>> GetFavoriteBooks(int studentId)
        {
            List<StudentBook> result = await studentBookRepository.GetByUser(studentId);

            return result;
        }

        public async Task DeleteFavoriteBook(int studentId, int bookId)
        {
            IEnumerable<StudentBook> result = await studentBookRepository.Get();
            var a = result.FirstOrDefault(x => x.BookId == bookId && x.StudentId == studentId);
            await studentBookRepository.Delete(a);
        }

        public async Task<IEnumerable<TeacherBook>> GetTeacherBooks(int teacherId)
        {
            IEnumerable<TeacherBook> result = await teacherBookRepository.Get();
            result = result.Where(item => item.TeacherId == teacherId);

            return result;
        }

        public async Task DeleteTeacherBook(int teacherId, int bookId)
        {
            IEnumerable<TeacherBook> result = await teacherBookRepository.Get();
            var a = result.FirstOrDefault(x => x.BookId == bookId && x.TeacherId == teacherId);
            await teacherBookRepository.Delete(a);
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await bookRepository.Get();
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await genreRepository.Get();
        }

        public async Task<IEnumerable<Book>> GetBooksBySubject(string subjectName)
        {
            Subject subject = (await subjectRepository.Get()).FirstOrDefault(item => item.Name == subjectName);

            return (await GetAllBooks()).Where(x => x.SubjectId == subject.Id);
        }
    }
}