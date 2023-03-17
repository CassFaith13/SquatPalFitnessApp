using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Data.Entities;
using SquatPal.Models.ExercisePlanModels;
using SquatPal.Services.Services.IServices;

namespace SquatPal.Services.Services
{
    public class ExercisePlanService : IExercisePlanService
    {
        private readonly ApplicationDbContext _context;
        public ExercisePlanService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateExercisePlan(ExercisePlanCreate model)
        {
            var exercise = new ExercisePlan
            {
                Name = model.Name,
                ExerciseType = model.ExerciseType,
                WorkoutOne = model.WorkoutOne,
                WorkoutTwo = model.WorkoutTwo,
                WorkoutThree = model.WorkoutThree,
                WorkoutFour = model.WorkoutFour,
                WorkoutFive = model.WorkoutFive,
                MusclesActivated = model.MusclesActivated,
            };
            _context.Exercises.Add(exercise);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<List<ExercisePlanListItem>> GetExercisePlans()
        {
            var exercises = await _context.Exercises.Select(e => new ExercisePlanListItem()
            {
                ExercisePlanId = e.ExercisePlanId,
                Name = e.Name
            }).ToListAsync();
            return exercises;
        }
        public async Task<ExercisePlanDetail> GetExercisePlan(int id)
        {
            ExercisePlan exercise = await _context.Exercises.FirstOrDefaultAsync(e => e.ExercisePlanId == id);
            
            ExercisePlanDetail exercisePlanDetail = new ExercisePlanDetail()
            {
                ExercisePlanId = exercise.ExercisePlanId,
                Name = exercise.Name,
                ExerciseType = exercise.ExerciseType,
                WorkoutOne = exercise.WorkoutOne,
                WorkoutTwo = exercise.WorkoutTwo,
                WorkoutThree = exercise.WorkoutThree,
                WorkoutFour = exercise.WorkoutFour,
                WorkoutFive = exercise.WorkoutFive,
                MusclesActivated = exercise.MusclesActivated
            };
            return exercisePlanDetail;
        }
        public async Task<bool> UpdateExercisePlan(int id, ExercisePlanEdit model)
        {
            var exerciseInDb = await _context.Exercises.FindAsync(id);

            if (exerciseInDb is null)
            {
                return false;
            }

            exerciseInDb.Name = model.Name;
            exerciseInDb.ExerciseType = model.ExerciseType;
            exerciseInDb.WorkoutOne = model.WorkoutOne;
            exerciseInDb.WorkoutTwo = model.WorkoutTwo;
            exerciseInDb.WorkoutThree = model.WorkoutThree;
            exerciseInDb.WorkoutFour = model.WorkoutFour;
            exerciseInDb.WorkoutFive = model.WorkoutFive;
            exerciseInDb.MusclesActivated = model.MusclesActivated;

            return await _context.SaveChangesAsync() == 1;
        }
        public async Task<bool> DeleteExercisePlan(int id)
        {
            var exerciseDelete = await _context.Exercises.FirstOrDefaultAsync(e => e.ExercisePlanId == id);

            if (exerciseDelete is null)
            {
                return false;
            }

            _context.Exercises.Remove(exerciseDelete);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}