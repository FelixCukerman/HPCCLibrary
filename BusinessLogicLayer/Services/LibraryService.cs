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

        public async Task CreateBook(CreateBookViewModel book)
        {
            Book bookToCreate = mapper.Map<Book>(book);
            await bookRepository.Create(bookToCreate);

        }
    }
}
