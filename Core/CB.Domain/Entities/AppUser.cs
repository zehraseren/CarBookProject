namespace CB.Domain.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
