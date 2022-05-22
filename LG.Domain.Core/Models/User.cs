namespace LG.Domain.Core.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsVerified { get; set; }
    }
}