using PoliciesWebApp.Models;
using System.ComponentModel.DataAnnotations;
 

namespace PoliciesWebApp.Validations
{
    public class ValidateCoverage : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is float))
            {

                return new ValidationResult("coverage must be a float type");
            }
            else if ((float)value > 100)
            {

                return new ValidationResult("coverage must less than or equal to 100");
            }
            ERiskTypes riskType = ((IPolicy)validationContext.ObjectInstance).RiskId;
            if ((float)value > 50 && riskType == ERiskTypes.High)
            {
                return new ValidationResult("coverage must be less than or equal to 50 when the risk is high");
            }

            return ValidationResult.Success;
        }
    }
}
