namespace SquatPal.Models.ExercisePlanModels
{
    public class ExercisePlanDetail
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; } = null!;
        public string ExerciseType { get; set; } = null!;
        public string MusclesActivated { get; set; } = null!;
    }   
}