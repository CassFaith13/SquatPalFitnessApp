using SquatPal.Models.ClientModels;

namespace SquatPal.Services.Services.IServices
{
    public interface IClientService
    {
        Task<bool> CreateClient(ClientCreate model);
        Task<List<ClientListItem>> GetClients();
        Task<ClientDetail> GetClient(int id);
        Task<bool> UpdateClient(ClientEdit model);
    }
}