using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Logo { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

//Id: int
//Name : string
//Logo : blob
