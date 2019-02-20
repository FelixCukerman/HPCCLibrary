using EntitiesLayer.Abstraction;
using EntitiesLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public Speciality Speciality { get; set; }
        public Course Course { get; set; }
    }
}
