using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
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
        public async Task<IEnumerable<Genre>> Get()
        {
            return await libraryService.GetAllGenre();
        }


        public async Task CreateBook(Book book)
        {
            await libraryService.CreateBook(book);
        }

    }
}
