﻿using EntitiesLayer.Abstraction;
using EntitiesLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class Student : BaseUserEntity
    {
        public Course Course { get; set; }
        public int? GroupeId { get; set; }
        [ForeignKey("GroupeId")]
        public Groupe Groupe { get; set; }

        public Student()
        {
            DateOfCreation = DateTime.Now;
        }
    }
}
