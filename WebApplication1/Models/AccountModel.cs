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

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Range(10, 80)]
        public int Age { get; set; }
        public CityEnum City { get; set; }
    }
}
