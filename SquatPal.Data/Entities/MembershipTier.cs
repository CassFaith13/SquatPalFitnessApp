using System.ComponentModel.DataAnnotations;

namespace SquatPal.Data.Entities
{
    public class MembershipTier
    {
        [Key]
        public int MembershipTierId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public double Price { get; set; }
        [Required]
        public string Benefits { get; set; } = null!;
    }
}