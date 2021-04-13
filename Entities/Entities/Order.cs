using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public double Price { get; set; }
        public DiscountCoupon DiscountCoupon { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

//Id: int
//UserId : int
//Price : double
//DiscountCoupon : string