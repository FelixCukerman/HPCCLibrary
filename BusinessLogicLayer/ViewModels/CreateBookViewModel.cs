using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.ViewModels
{
    public class CreateBookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int GenreId { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
    }
}
