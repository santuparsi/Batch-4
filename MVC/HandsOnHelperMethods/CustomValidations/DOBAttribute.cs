using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HandsOnHelperMethods.Models;
namespace HandsOnHelperMethods.CustomValidations
{
    public class DOBAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //User obj = validationContext.ObjectInstance as User;
            //if(obj.Pwd==value.ToString())
            //{

            //}

            DateTime dt = Convert.ToDateTime(value);
            if(dt>DateTime.Now)
            {
                return new ValidationResult("DOB should not be the future Date");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
