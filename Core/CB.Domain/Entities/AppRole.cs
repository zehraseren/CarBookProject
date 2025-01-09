namespace CB.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleId { get; set; }
        public string Name { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
