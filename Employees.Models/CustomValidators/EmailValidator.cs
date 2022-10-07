using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Models.CustomValidators
{
    public class EmailValidator:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings[1].ToUpper() == "DRICKSOFT.NET")
            {
                return null;
            }

            return new ValidationResult("Email addres is not valid", new[] {validationContext.MemberName});
        }
    }
}
