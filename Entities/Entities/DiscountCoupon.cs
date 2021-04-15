using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class DiscountCoupon
    {
        public int Id { get; set; }
        public string Coupon { get; set; }
        public double DiscountPercentage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Status
        {
            get
            {
                return Status;
            }
            private set
            {
                Status = IsCouponValid();
            }
        }

        private bool IsCouponValid()
        {
            if (DateTime.Now > ExpirationDate)
                return false;
            return true;
        }
    }
}

//DiscountCoupons
//Id : int
//Coupon : string
//DiscountPercentage : double
//ExpirationDate : DateTime
//Status : bool