using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SquatPal.Models.ExercisePlanModels
{
    public class ExercisePlanCreate
    {
        [Required]
        [DisplayName("Name of Exercise")]
        public string? Name { get; set; } = null!;
        [Required]
        [DisplayName("Type of Exercise")]
        public string? ExerciseType { get; set; } = null!;
        [Required]
        [DisplayName("Muscles Activated")]
        public string? MusclesActivated { get; set; } = null!;   
    }
}