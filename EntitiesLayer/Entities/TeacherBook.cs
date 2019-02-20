using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class TeacherBook : BaseEntity
    {
        public int? BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        public TeacherBook()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
