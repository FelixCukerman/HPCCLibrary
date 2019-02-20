using EntitiesLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntitiesLayer.Abstraction
{
    public abstract class BaseUserEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public Sex Sex { get; set; }
        [Required]
        public UserRole UserRole { get; set; }
    }
}
