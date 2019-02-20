using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class StudentBook : BaseEntity
    {
        public int? BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public StudentBook()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
