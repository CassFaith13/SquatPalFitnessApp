using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SquatPal.Data.Entities
{
    public class AdminUser : IdentityUser
    {
        public int AdminUserId { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string AdminEmail { get; set; } = null!;
        [Required]
        public string AdminUsername { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}