using SquatPal.Models.MembershipTierModels;

namespace SquatPal.Services.Services.IServices
{
    public interface IMembershipTierService
    {
        Task<bool> CreateMembershipTier(MembershipTierCreate model);
        Task<List<MembershipTierListItem>> GetMembershipTiers();
        Task<MembershipTierDetail> GetMembershipTier(int id);
        Task<bool> UpdateMembershipTier(int id, MembershipTierEdit model);
        Task<bool> DeleteMembershipTier(int id);
    }
}