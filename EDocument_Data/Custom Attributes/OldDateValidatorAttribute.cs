using System.ComponentModel.DataAnnotations;
namespace EDocument_Data.Custom_Attributes;

public class OldDateValidatorAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        string propertyName = validationContext.MemberName;

        if (value != null && value is DateTime date)
        {
            if (date < DateTime.Now)
            {
                return new ValidationResult(ErrorMessage ?? $"You cannot submit {propertyName} in the past.");
            }
        }

        return ValidationResult.Success;
    }
}