using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;


namespace StudioEF.Validaciones
{
    public class ValidacionId : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int id = 0;

                try
                {
                    id = Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    return new ValidationResult("No es un ID valido");
                }

                if (id >= 0)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("El ID debe ser mayor o igual a cero");
            }
            return new ValidationResult("Debes poner un ID");
        }
    }
}
