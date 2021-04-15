using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Shipping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ExpectedArriveDate { get; set; }
        public DateTime? ArriveDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public EShippingStatus Status { get; set; }
        public bool? ShippingIsInTime { get; private set; }

        public void Arrived()
        {
            if (Status != EShippingStatus.Canceled && Status != EShippingStatus.Arrived)
            {
                ArriveDate = DateTime.Now;
                Status = EShippingStatus.Arrived;
                ArrivedInTime();
            }
        }

        public void Cancel()
        {
            if (Status != EShippingStatus.Canceled)
            {
                Status = EShippingStatus.Canceled;
            }
        }

        private void ArrivedInTime()
        {
            if (Status == EShippingStatus.Arrived)
            {
                ShippingIsInTime = ArriveDate <= ExpectedArriveDate;
            }
        }
    }
}

//Shippings
//Id : int
//User : int
//ShipFrom : int
//ShipTo : int
//ExpectedArriveDate : DateTime
//ArriveDate : DateTime
//DepartureDate : DateTime
