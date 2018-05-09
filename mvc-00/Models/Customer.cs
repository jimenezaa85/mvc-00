using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Attributes;

namespace mvc_00.Models
{
    [Validator(typeof(CustomerValidator))]
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Discount { get; set; }
        public string Address { get; set; }

        public IList<Pet> Pets { get; set; } 

        public Customer()
        {
            this.Pets = new List<Pet>();
        }
    }

    public class Pet
    {
        public string  Name { get; set; }
    }



    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            CascadeMode = CascadeMode.Continue;

            RuleFor(c => c.Id).GreaterThan(0).WithMessage("Id not should be empty");
            RuleFor(c => c.FirstName).NotNull().WithMessage("First Name should not be empty");
            RuleFor(c =>c.Pets).Must(list =>list.Count <=10).WithMessage("The list must contain fewer than 10 items");

        }
    }


}