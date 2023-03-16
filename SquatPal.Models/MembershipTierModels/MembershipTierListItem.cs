namespace SquatPal.Models.MembershipTierModels
{
    public class MembershipTierListItem
    {
        public int MembershipTierId { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
    }
}