using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SquatPal.Models.ExercisePlanModels
{
    public class ExercisePlanCreate
    {
        [Required]
        [DisplayName("Name of Exercise")]
        public string Name { get; set; } = null!;
        [Required]
        [DisplayName("Type of Exercise")]
        public string? ExerciseType { get; set; } = null!;
        [Required]
        [DisplayName("Workout #1")]
        public string WorkoutOne { get; set; } = null!;
        [DisplayName("Workout #2")]
        public string? WorkoutTwo { get; set; }
        [DisplayName("Workout #3")]
        public string? WorkoutThree { get; set; }
        [DisplayName("Workout #4")]
        public string? WorkoutFour { get; set; }
        [DisplayName("Workout #5")]
        public string? WorkoutFive { get; set; }
        [Required]
        [DisplayName("Muscles Activated")]
        public string? MusclesActivated { get; set; } = null!;   
    }
}