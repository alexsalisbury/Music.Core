using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Music.ConsoleApp.Validation
{
    public class AllowedScalesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var scaleDefinitions = ScaleEnumerator.ScaleTypes.Select(x => x.Name.Replace("Scale", "")).ToArray();

            if (value is string scale && !scaleDefinitions.Any(s => s.ToLowerInvariant() == scale.ToLowerInvariant()))
            {
                return new ValidationResult("Available scales are: " + string.Join(", ", scaleDefinitions));
            }

            return ValidationResult.Success;
        }
    }
}
