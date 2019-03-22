using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HPCCLibrary.Models;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;

namespace HPCCLibrary.Controllers
{
    public class HomeController : Controller
    {
        private ILibraryService libraryService;
        public HomeController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            CreateBookViewModel book = new CreateBookViewModel { Author = "1", Genre = "Action", Language = "2", Publisher = "3", Title = "4", Year = 1290 };
            await libraryService.CreateBook(book);
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
