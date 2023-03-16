using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SquatPal.Models.MembershipTierModels
{
    public class MembershipTierCreate
    {
        [Required]
        [DisplayName("Membership Tier")]
        public string Name { get; set; } = null!;
        [Required]
        public double Price { get; set; }
        [Required]
        public string Benefits { get; set; } = null!;
    }
}