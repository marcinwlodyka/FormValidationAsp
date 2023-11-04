using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Account
    {
        public enum CityEnum
        {
            Krakow,
            Warsow,
            Paris,
            London,
            NewYork
        }

        [Required] [MinLength(2)] public string FirstName { get; set; } = string.Empty;
        [Required] [MinLength(2)] public string Surname { get; set; } = string.Empty;
        [Required] [EmailAddress] public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(
            "(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}",
            ErrorMessage = "Hasło musi posiadać przynajmniej: jedną dużą literę, jedną małą literę, jedną cyfrę i mieć co najmniej 8 znaków"
        )]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Phone] public string PhoneNumber { get; set; } = string.Empty;
        [Range(10, 80)] public int Age { get; set; }
        public CityEnum City { get; set; }
    }
}