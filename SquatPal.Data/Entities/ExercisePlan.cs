using System.ComponentModel.DataAnnotations;

namespace SquatPal.Data.Entities
{
    public class ExercisePlan
    {
        [Key]
        public int ExerciseId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string ExerciseType { get; set; } = null!;
        [Required]
        public string MusclesActivated { get; set; } = null!;
    }
}