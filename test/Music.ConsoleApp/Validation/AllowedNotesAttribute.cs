using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Music.ConsoleApp.Validation
{
    public class AllowedNotesAttribute : ValidationAttribute
    {
        private static string[] allowedNotes = new[] { "A", "Ab", "A#", "B", "Bb", "C", "C#", "D", "Db", "D#", "E", "Eb", "F", "F#", "G", "Gb", "G#" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string note && !allowedNotes.Any(s => s.ToLowerInvariant() == note.ToLowerInvariant()))
            {
                return new ValidationResult("Available notes are: " + string.Join(", ", allowedNotes));
            }

            return ValidationResult.Success;
        }
    }
}
