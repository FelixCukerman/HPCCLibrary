using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;

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

        public LibraryService(IBookRepository bookRepository, IGenreRepository genreRepository, IGroupeRepository groupeRepository, IStudentRepository studentRepository, IStudentBookRepository studentBookRepository, ISubjectRepository subjectRepository)
        {
            this.bookRepository = bookRepository;
            this.genreRepository = genreRepository;
            this.groupeRepository = groupeRepository;
            this.studentRepository = studentRepository;
            this.studentBookRepository = studentBookRepository;
            this.subjectRepository = subjectRepository;
        }

        public async Task<IEnumerable<Genre>> GetAllGenre()
        {
            var result = await genreRepository.Get();
            return result;
        }
    }
}
