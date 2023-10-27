using System.ComponentModel.DataAnnotations;

namespace DateValidator.Models;
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        DateTime FutureDateTime = (DateTime)value;
        if (FutureDateTime > DateTime.Now)
        {
            return new ValidationResult("No se permiten fechas mayores a la actual");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}