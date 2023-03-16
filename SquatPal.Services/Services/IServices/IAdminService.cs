using SquatPal.Models.AdminUserModels;

namespace SquatPal.Services.Services.IServices
{
    public interface IAdminUserService
    {
        Task<bool> CreateAdminUser(AdminUserCreate model);
        Task<List<AdminUserListItem>> GetAdmins();
        Task<AdminUserDetail> GetAdminUser(int id);
    }
}