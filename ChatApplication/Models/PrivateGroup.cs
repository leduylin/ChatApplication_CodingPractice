namespace ChatApplication.Models
{
    public class PrivateGroup : Group
    {
        public int Id { get; set; }
        public User Admin { get; set; }
        public List<User> UsersList { get; set; }
       
    }
}
