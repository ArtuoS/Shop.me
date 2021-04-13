using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public int Country { get; set; }
        public int State { get; set; }
        public int City { get; set; }
        public ICollection<User> Users { get; set; }
    }
}

//Id: int
//UserId : int
//Country : string
//State : string
//City : string