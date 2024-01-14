namespace Models.Entities
{
    public class Account
    {
        public long Id { get; set; }

        public string Fullname { get; set; } = null!;

        public string Email { get; set; } = null!;
        
        public string Password { get; set; } = null!;
        
        public string? Address { get; set; }
        
        public string? Avatar { get; set; }

        public bool IsActived { get; set; }

        public bool IsDeleted { get; set; }
    }
}
