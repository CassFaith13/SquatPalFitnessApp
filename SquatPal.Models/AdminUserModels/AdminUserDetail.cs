namespace SquatPal.Models.AdminUserModels
{
    public class AdminUserDetail
    {
        public int AdminUserId { get; set; }
        public string AdminUsername { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}