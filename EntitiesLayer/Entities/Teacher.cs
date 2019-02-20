using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class Teacher : BaseUserEntity
    {
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public Teacher()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
