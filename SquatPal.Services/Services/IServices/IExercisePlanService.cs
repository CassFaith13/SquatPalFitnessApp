using SquatPal.Models.ExercisePlanModels;

namespace SquatPal.Services.Services.IServices
{
    public interface IExercisePlanService
    {
        Task<bool> CreateExercisePlan(ExercisePlanCreate model);
        Task<List<ExercisePlanListItem>> GetExercisePlans();
        Task<ExercisePlanDetail> GetExercisePlan(int id);
        Task<bool> UpdateExercisePlan(int id, ExercisePlanEdit model);
        Task<bool> DeleteExercisePlan(int id);
    }
}