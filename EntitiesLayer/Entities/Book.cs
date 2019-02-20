using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesLayer.Entities
{
    //add filelink
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int? GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }

        public Book()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
