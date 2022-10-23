using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Constants;
using FluentValidation;
using EPolling.Application.Model.Identity;


namespace EPolling.Application.Command.Request.Data.SignIn
{
    public class SignInValidator : AbstractValidator<LoginRequest>
    {
        public SignInValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("{PropertyName} is not a Valid Email")
                .Matches(Regex.EMAIL).WithMessage("{PropertyName} is not a Valid Email");

            RuleFor(x => x.Password).NotEmpty().WithMessage("{PropertyName} is required")
                .MinimumLength(8).WithMessage("{PropertyName} cannot be less than 8")
                .Matches(Regex.PASSWORD).WithMessage("{PropertyName} Should contains at least one uppercase letter, one lowercase letter, one number and one special character");
        }
    }
}
