using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Store> Stores { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

//Id: int
//Name : string
//Price : double
//Weight : double
//UnitOfMeasurement : int