using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Data.Entities;
using SquatPal.Models.ClientModels;
using SquatPal.Services.Services.IServices;

namespace SquatPal.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateClient(ClientCreate model)
        {
            var client = new Client
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                HeightInches = model.HeightInches,
                WeightLbs = model.WeightLbs,
                GoalWeight = model.GoalWeight,
                MembershipId = model.MembershipId,
                ExerciseId = model.ExerciseId
            };

            _context.Clients.Add(client);

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<List<ClientListItem>> GetClients()
        {
            var clients = await _context.Clients
            .Include(c => c.MembershipTier)
            .Select(c => new ClientListItem()
            {
                ClientId = c.ClientId,
                FirstName = c.FirstName,
                MembershipTierName = c.MembershipTier.Name
            }).ToListAsync();
            return clients;
        }
        public async Task<ClientDetail> GetClient(int id)
        {
            var client = await _context.Clients
            .Include(c => c.MembershipTier)
            .Include(c => c.ExercisePlan)
            .SingleOrDefaultAsync(c => c.ClientId == id);

            ClientDetail clientDetail = new ClientDetail()
            {
                ClientId = client.ClientId,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                HeightInches = client.HeightInches,
                WeightLbs = client.WeightLbs,
                GoalWeight = client.GoalWeight,
                MembershipId = client.MembershipId,
                ExerciseId = client.ExerciseId,
                MembershipTierName = client.MembershipTier.Name,
                ExercisePlanName = client.ExercisePlan.Name
            };
            return clientDetail;
        }
        public async Task<bool> UpdateClient(ClientEdit model)
        {
            var clientInDb = await _context.Clients.FindAsync(model.ClientId);

            if (clientInDb is null)
            {
                return false;
            }

            clientInDb.FirstName = model.FirstName;
            clientInDb.LastName = model.LastName;
            clientInDb.Email = model.Email;
            clientInDb.HeightInches = model.HeightInches;
            clientInDb.WeightLbs = model.WeightLbs;
            clientInDb.GoalWeight = model.GoalWeight;
            clientInDb.MembershipId = model.MembershipId;
            clientInDb.ExerciseId = model.ExerciseId;
            
            return await _context.SaveChangesAsync() == 1;
        }
    }
}