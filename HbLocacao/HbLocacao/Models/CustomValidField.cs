using HbLocacao.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HbLocacao.Models
{
    public class CustomValidField : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidField(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome: { return ValidarNome(value, validationContext.DisplayName); }
                    default: { } break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatorio");
        }
        private ValidationResult ValidarNome(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z]");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

    }
}