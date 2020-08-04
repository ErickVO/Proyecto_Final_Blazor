using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudioEF.Validaciones
{
    public class CantidadValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = Convert.ToDecimal(value);

                if (cantidad >= 1)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("La cantidad debe mayor o igual a 1");

            }
            return new ValidationResult("Debes poner una cantidad");
        }
    }
}