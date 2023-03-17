using System.ComponentModel.DataAnnotations;

namespace SquatPal.Data.Entities
{
    public class ExercisePlan
    {
        [Key]
        public int ExercisePlanId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string ExerciseType { get; set; } = null!;
        [Required]
        public string WorkoutOne { get; set; } = null!;
        public string? WorkoutTwo { get; set; }
        public string? WorkoutThree { get; set; }
        public string? WorkoutFour { get; set; }
        public string? WorkoutFive { get; set; }
        [Required]
        public string MusclesActivated { get; set; } = null!;
    }
}