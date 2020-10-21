using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Validators
{
    public class RegisterViewModelValidator:AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Adress).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
        }
    }
}
