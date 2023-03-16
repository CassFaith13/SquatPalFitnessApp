namespace SquatPal.Models.MembershipTierModels
{
    public class MembershipTierDetail
    {
        public int MembershipTierId { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string Benefits { get; set; } = null!;
    }
}