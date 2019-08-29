using HBGaragem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HBGaragem.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome: { return ValidaNomes(value, validationContext.DisplayName); } 
                    case ValidFields.ValidaEmail: { return ValidaEmail(value, validationContext.DisplayName); } 
                    case ValidFields.ValidaPlaca: { return ValidarPlaca(value, validationContext.DisplayName); } 
                    default: { } break;
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatorio.");
        }

        private ValidationResult ValidaNomes(object value,string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z]");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido:");
        }

        private ValidationResult ValidaEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidarPlaca(object value, string displayField)
        {
            bool Placa = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{ 3}[0-9]{4}$");

            bool PlacaMer = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");

            if (Placa)
            {
                return ValidationResult.Success;
            }
            else if (PlacaMer)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"O campo {displayField} é invalido.");
            }
        }
    }
}