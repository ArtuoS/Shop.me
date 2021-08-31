using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public EGender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}