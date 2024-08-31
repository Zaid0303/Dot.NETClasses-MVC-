using System.ComponentModel.DataAnnotations;

namespace classes.net.Models
{
    public class CustomValModal 
    {

        public class CustomValModalViewModel : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime birthday = (DateTime)value;
                if (birthday.Year < 1900)
                    return new ValidationResult("Surely You Are Not That Old?");
                if (birthday.Year < 2000)
                    return new ValidationResult("Sorry You're Too Young For This Website");
                if (birthday.Month == 12)
                    return new ValidationResult("Sorry You're Don't Accept Anyone Born in December!");
                return ValidationResult.Success;
            }
        }

    }
}
