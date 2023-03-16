// using SquatPal.Data.Entities.ENUMS;
using SquatPal.Data.Entities;
using SquatPal.Models.ExercisePlanModels;
using SquatPal.Models.MembershipTierModels;

namespace SquatPal.Models.ClientModels
{
    public class ClientDetail
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int HeightInches { get; set; }
        public int WeightLbs { get; set; }
        public int GoalWeight { get; set; }
        public int MembershipId { get; set; }
        public string MembershipTierName { get; set; } = null!;
        public virtual MembershipTierListItem MembershipTier { get; set; } = null!;
        public List<ExercisePlan> Exercises { get; set; } = new List<ExercisePlan>();
    }
}