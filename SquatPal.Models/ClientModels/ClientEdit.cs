using System.ComponentModel.DataAnnotations;
using SquatPal.Data.Entities;
using SquatPal.Models.ExercisePlanModels;

namespace SquatPal.Models.ClientModels
{
    public class ClientEdit
    {
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public int HeightInches { get; set; }
        [Required]
        public int WeightLbs { get; set; }
        [Required]
        public int GoalWeight { get; set; }
        [Required]
        public int MembershipId { get; set; }
        public List<ExercisePlan>? Exercises { get; set; }
    }
}