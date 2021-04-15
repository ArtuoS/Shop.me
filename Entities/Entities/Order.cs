using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public string DiscountCoupon { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

//Id: int
//UserId : int
//Price : double
//DiscountCoupon : string