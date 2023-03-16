using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SquatPal.Models.AdminUserModels
{
    public class AdminUserCreate
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [MinLength(4)]
        public string AdminUsername { get; set; } = null!;
        [Required]
        [RegularExpression(("^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,}$"), ErrorMessage = "Password must be 6 or more characters with at least one letter and one Number!")]
        public string? Password { get; set; } = null!;
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
    }
}