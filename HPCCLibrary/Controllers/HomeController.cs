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
            var a = await libraryService.GetAllGenre();
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
