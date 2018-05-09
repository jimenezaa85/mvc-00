using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_00.Infraestructure
{
    public class DependencyResolverModelValidatorFactory : IValidatorFactory
    {
        public IValidator GetValidator(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return DependencyResolver.Current.GetService(typeof(IValidator<>).MakeGenericType(type)) as IValidator;
        }

        public IValidator<T> GetValidator<T>()
        {
            return DependencyResolver.Current.GetService<IValidator<T>>();
        }
    }
}