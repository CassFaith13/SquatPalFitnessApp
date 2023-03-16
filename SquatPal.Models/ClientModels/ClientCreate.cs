using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SquatPal.Data.Entities;
using SquatPal.Models.ExercisePlanModels;

namespace SquatPal.Models.ClientModels
{
    public class ClientCreate
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
        [DisplayName("Height In Inches")]
        public int HeightInches { get; set; }
        [Required]
        [DisplayName("Weight In Pounds")]
        public int WeightLbs { get; set; }
        [Required]
        [DisplayName("Goal Weight")]
        public int GoalWeight { get; set; }
        [Required]
        [DisplayName("Membership Tier ID Number")]
        public int MembershipId { get; set; }
        public List<ExercisePlan>? Exercises { get; set; }
    }
}