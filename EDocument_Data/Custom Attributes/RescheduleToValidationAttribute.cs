using System;
using System.ComponentModel.DataAnnotations;
namespace EDocument_Data.Custom_Attributes;
public class RescheduleToValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var rescheduleFromProperty = validationContext.ObjectType.GetProperty("RescheduleFrom");
        var rescheduleFromValue = (DateTime)rescheduleFromProperty.GetValue(validationContext.ObjectInstance);

        if (value != null && value is DateTime rescheduleToValue)
        {
            if ((rescheduleToValue - rescheduleFromValue).TotalDays > 90)
            {
                return new ValidationResult(ErrorMessage ?? $"The interval between RescheduleFrom and RescheduleTo should not exceed 90 days.");
            }
        }

        return ValidationResult.Success;
    }
}