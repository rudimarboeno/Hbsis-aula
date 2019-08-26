using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                if (value.ToString().Contains(""))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Erro.");
                }
            }
            return new ValidationResult("O campo: " + validationContext.DisplayName + " é um campo obrigatorio.");
        }
    }
}