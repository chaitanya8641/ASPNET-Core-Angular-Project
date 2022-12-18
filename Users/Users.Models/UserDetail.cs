using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
    public class UserDetail
    {
        [Key]
        public Guid UserDetailsID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Active { get; set; }
    }
}
