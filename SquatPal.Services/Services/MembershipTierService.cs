using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Data.Entities;
using SquatPal.Models.MembershipTierModels;
using SquatPal.Services.Services.IServices;

namespace SquatPal.Services.Services
{
    public class MembershipTierService : IMembershipTierService
    {
        private readonly ApplicationDbContext _context;
        public MembershipTierService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateMembershipTier(MembershipTierCreate model)
        {
            var membership = new MembershipTier
            {
                Name = model.Name,
                Price = model.Price,
                Benefits = model.Benefits
            };
            _context.Memberships.Add(membership);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<List<MembershipTierListItem>> GetMembershipTiers()
        {
            var memberships = await _context.Memberships.Select(m => new MembershipTierListItem()
            {
                MembershipTierId = m.MembershipTierId,
                Name = m.Name,
                Price = m.Price
            }).ToListAsync();
            return memberships;
        }
        public async Task<MembershipTierDetail> GetMembershipTier(int id)
        {
            MembershipTier membership = await _context.Memberships.FirstOrDefaultAsync(m => m.MembershipTierId == id);
            MembershipTierDetail membershipTierDetail = new MembershipTierDetail()
            {
                MembershipTierId = membership.MembershipTierId,
                Name = membership.Name,
                Price = membership.Price,
                Benefits = membership.Benefits
            };
            return membershipTierDetail;
        }
        public async Task<bool> UpdateMembershipTier(int id, MembershipTierEdit model)
        {
            var membershipInDb = await _context.Memberships.FindAsync(id);

            if (membershipInDb is null)
            {
                return false;
            }

            membershipInDb.Name = model.Name;
            membershipInDb.Price = model.Price;
            membershipInDb.Benefits = model.Benefits;

            return await _context.SaveChangesAsync() == 1;
        }
        public async Task<bool> DeleteMembershipTier(int id)
        {
            var membershipDelete = await _context.Memberships.FirstOrDefaultAsync(m => m.MembershipTierId == id);

            if (membershipDelete is null)
            {
                return false;
            }
            _context.Memberships.Remove(membershipDelete);
            return await _context.SaveChangesAsync() == 1;
        }
    }
}