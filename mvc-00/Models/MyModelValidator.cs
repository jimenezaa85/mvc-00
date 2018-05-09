using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_00.Models
{
    public class MyModelValidator : AbstractValidator<MyModel>
    {
        public MyModelValidator()
        {
            RuleFor(m => m.Name)
              .NotEmpty()
              .WithMessage("Please provide a name.");

            RuleFor(m => m.Age)
              .GreaterThan(21)
              .WithMessage("You must be over 21 to access this site.");
        }
    }
}