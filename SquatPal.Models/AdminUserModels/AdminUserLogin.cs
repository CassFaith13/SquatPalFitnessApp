using System.ComponentModel.DataAnnotations;

namespace SquatPal.Models.AdminUserModels
{
    public class AdminUserLogin
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}