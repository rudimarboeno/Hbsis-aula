using HBGaragem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

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
                    case ValidFields.ValidaNome:  { return ValidaNomes(value, validationContext.DisplayName); } 
                    case ValidFields.ValidaEmail: { return ValidaEmail(value, validationContext.DisplayName); }
                    case ValidFields.ValidaPlaca: { return ValidarPlaca(value, validationContext); }
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

        private ValidationResult ValidarPlaca(object value, ValidationContext validationContext)
        {

            Veiculo veiculo = (Veiculo)validationContext.ObjectInstance;

            if (veiculo.TipodeVeiculo_Fk > 2 && value == null)
                return ValidationResult.Success;

            if (veiculo.TipodeVeiculo_Fk > 2 && value != null)
                return new ValidationResult("Esse tipo de veiculo não é permetido o cadastro de placa");

            if (veiculo.TipodeVeiculo_Fk == 1 && value != null)
            {
                if (Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$") 
                || Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$"))
                {
                    if (dB.Veiculos.Any(X => X.Placa == value.ToString()))
                        return new ValidationResult($"A placa '{value}' já possui um cadastrp no sistema");
                    return ValidationResult.Success;
                }
                return new ValidationResult($"Formato inválido no campo {validationContext.DisplayName}");
            }
            if (veiculo.TipodeVeiculo_Fk == 2 && value != null)
            {
                if(Regex.IsMatch(value.ToString(), @"^[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}$"))
                {
                    if (!dB.Veiculos.Any(x => x.Placa == value.ToString()))
                        return ValidationResult.Success;
                    return new ValidationResult($"A placa '{value}' já está cadastrada em nosso sistema");
                }
                return new ValidationResult($"A placa '{value.ToString()}' não está no formato aceitável");
            }
            return new ValidationResult($"O campo '{validationContext.DisplayName}' deve ser informado");
        }

      
    }
}