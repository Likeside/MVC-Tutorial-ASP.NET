using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Tutorial.CustomAttributes
{
    public class WebUserBirthdayValidationAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthday = (DateTime) value;

            if (birthday.Year < 1991)
            {
                return new ValidationResult("Старпер");
            }

            if (birthday.Year > 2003)
            {
                return new ValidationResult("На сайте контент 18+");
            }
            
            return ValidationResult.Success;

        }
    }
}