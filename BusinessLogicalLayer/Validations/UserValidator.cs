using Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicalLayer.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name).NotEmpty().MinimumLength(3).MaximumLength(60);
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(3).MaximumLength(60);
            RuleFor(u => u.DateOfBirthday).Must(ValidaDateOfBirthday).WithMessage("Must be a valid Date of Birthday.");
        }

        private bool ValidaDateOfBirthday(DateTime date)
        {
            if (string.IsNullOrWhiteSpace(date.ToString()))
                return false;
            else if (date == null)
                return false;
            else if (date > DateTime.Now)
                return false;
            else if (date < new DateTime(1900, 01, 01))
                return false;
            return true;
        }
    }
}
