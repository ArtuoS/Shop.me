using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Models.InsertViewModels
{
    public class UserInsertViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public EGender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
