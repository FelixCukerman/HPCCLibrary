using EntitiesLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Entities
{
    //add something
    public class Genre : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
