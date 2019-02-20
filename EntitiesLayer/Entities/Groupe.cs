using EntitiesLayer.Abstraction;
using EntitiesLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class Groupe : BaseEntity
    {
        [Required]
        public int Name { get; set; }
        [Required]
        public Course Course { get; set; }
        [Required]
        public GroupeType GroupeType { get; set; }

        public Groupe()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
