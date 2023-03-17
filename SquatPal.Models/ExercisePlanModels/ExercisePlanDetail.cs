namespace SquatPal.Models.ExercisePlanModels
{
    public class ExercisePlanDetail
    {
        public int ExercisePlanId { get; set; }
        public string Name { get; set; } = null!;
        public string ExerciseType { get; set; } = null!;
        public string WorkoutOne { get; set; } = null!;
        public string? WorkoutTwo { get; set; }
        public string? WorkoutThree { get; set; }
        public string? WorkoutFour { get; set; }
        public string? WorkoutFive { get; set; }
        public string MusclesActivated { get; set; } = null!;
    }   
}