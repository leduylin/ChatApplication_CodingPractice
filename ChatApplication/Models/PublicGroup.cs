namespace ChatApplication.Models
{
    public class PublicGroup : Group
    {
        public int Id { get; set; }
        public List<User> UsersList { get; set; }
        public User PrimaryAdmin { get; set; }
        public List<User> AdminsList { get; set; }
    }
}
