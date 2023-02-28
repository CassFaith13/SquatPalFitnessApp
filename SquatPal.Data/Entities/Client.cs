using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquatPal.Data.Entities
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string? FirstName { get; set; } = null!;
        [Required]
        public string? LastName { get; set; } = null!;
        [Required]
        public string? Email { get; set; } = null!;
        [Required]
        public decimal HeightInches { get; set; }
        [Required]
        public decimal WeightLbs { get; set; }
        [Required]
        public int GoalWeight { get; set; }
        public int MembershipTierId { get; set; }
        [ForeignKey(nameof(MembershipTierId))]
        public virtual MembershipTier MembershipTier { get; set; } = null!;
        public List<ExercisePlan> Exercises { get; set; } = new List<ExercisePlan>();
    }
}