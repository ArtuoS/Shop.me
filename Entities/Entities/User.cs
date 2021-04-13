using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
        public int AdressId { get; set; }
        public Adress Adress { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}

// Id: int
// Name : string
// LastName : string
// DateOfBirthday : DateTime
// Gender : EGender int
// Email : string
// Password : string
// AdressId : int