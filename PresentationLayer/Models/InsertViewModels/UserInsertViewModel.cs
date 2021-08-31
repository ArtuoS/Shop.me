using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Models.InsertViewModels
{
    public class UserInsertViewModel
    {
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Sobrenome")]
        public string LastName { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DateOfBirthday { get; set; }

        [DisplayName("Gênero")]
        public EGender Gender { get; set; }
        
        public string Email { get; set; }

        [DisplayName("Senha")]
        public string Password { get; set; }

        [DisplayName("País")]
        public string Country { get; set; }

        [DisplayName("Estado")]
        public string State { get; set; }

        [DisplayName("Cidade")]
        public string City { get; set; }
    }
}
