using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

//Id: int
//Name : string
//Description : string