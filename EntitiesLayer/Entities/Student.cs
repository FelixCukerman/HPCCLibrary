using EntitiesLayer.Abstraction;
using EntitiesLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Entities
{
    public class Student : BaseUserEntity
    {
        public Course Course { get; set; }
        public int Groupe
    }
}
