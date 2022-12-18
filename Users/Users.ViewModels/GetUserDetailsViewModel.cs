namespace Users.ViewModels
{
    public class GetUserDetailsViewModel
    {
        public Guid UserDetailsID { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
