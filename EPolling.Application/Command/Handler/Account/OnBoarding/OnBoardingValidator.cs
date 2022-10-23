using EPolling.Application.Constants;
using EPolling.Application.Dto.OnBoarding;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Command.Handler.Account.OnBoarding
{
    public class OnBoardingValidator : AbstractValidator<UserDetailDto>
    {
        public OnBoardingValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} is required")
                .Matches(Regex.ALPHABET).WithMessage("{PropertyName} can only contains Alphabets")
                .MaximumLength(50).WithMessage("{PropertyName} can not be Longer than {ComaprisonValue} Characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} is required")
                .Matches(Regex.ALPHABET).WithMessage("{PropertyName} can only contains Alphabets")
                .MaximumLength(50).WithMessage("{PropertyName} can not be Longer than {ComaprisonValue} Characters");


            RuleFor(x => x.DOB).NotNull().WithMessage("{PropertyName} is required")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(x => x.PVC).NotEmpty().WithMessage("{PropertyName} is required")
                .Matches(Regex.DIGIT).WithMessage("{PropertyName} can only contains Digit")
                .MaximumLength(50).WithMessage("{PropertyName} can not be Longer than {ComaprisonValue} Characters");

            RuleFor(x => x.State).NotEmpty().WithMessage("{PropertyName} is required").
                IsInEnum().WithMessage("{PropertyName} is not in Enum");

            RuleFor(x => x.PollingUnit).NotEmpty().WithMessage("{PropertyName} is required").
                IsInEnum().WithMessage("{PropertyName} is not in Enum");

        }
    }
}
