namespace SquatPal.Models.ClientModels
{
    public class ClientListItem
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; } = null!;
        public string MembershipTierName { get; set; } = null!;
    }
}