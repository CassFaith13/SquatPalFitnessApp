using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Data.Entities;
using SquatPal.Models.AdminUserModels;
using SquatPal.Services.Services.IServices;

namespace SquatPal.Services.Services
{
    public class AdminUserService : IAdminUserService
    {
        private readonly ApplicationDbContext _context;
        public AdminUserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAdminUser(AdminUserCreate model)
        {

            var admin = new AdminUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Username = model.Username,
                Password = model.Password
            };

            
            _context.Admins.Add(admin);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<List<AdminUserListItem>> GetAdmins()
        {
            var admins = await _context.Admins.Select(a => new AdminUserListItem()
            {
                AdminUserId = a.AdminUserId,
                FirstName = a.FirstName,
                LastName = a.LastName
            }).ToListAsync();
            return admins;
        }
        public async Task<AdminUserDetail> GetAdminUser(int id)
        {
            var adminUser = await _context.Admins.SingleOrDefaultAsync(a => a.AdminUserId == id);

            AdminUserDetail adminUserDetail = new AdminUserDetail()
            {
                AdminUserId = adminUser.AdminUserId,
                Username = adminUser.Username,
                Email = adminUser.Email,
                FirstName = adminUser.FirstName,
                LastName = adminUser.LastName
            };
            return adminUserDetail;
        }
    }
}