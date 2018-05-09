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
        public virtual Text FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Discount { get; set; }
        public string Address { get; set; }
    }



    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Id).NotNull().WithMessage("Debe ser > 10");
            RuleFor(customer => customer.FirstName).NotNull().WithMessage("sfdasfsda");
            
        }
    }


}