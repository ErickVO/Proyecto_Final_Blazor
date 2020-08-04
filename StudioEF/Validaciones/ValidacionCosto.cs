using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;


namespace StudioEF.Validaciones
{
    public class ValidacionCosto : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = 0;
                try
                {
                    cantidad = Convert.ToDecimal(value);
                }
                catch
                {
                    return new ValidationResult("El costo debe ser un numero");
                }

                if (cantidad >= 1m)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("El costo debe mayor o igual a 1");

            }
            return new ValidationResult("Debes poner un costo");
        }
    }
}    


