namespace ChatApplication.Models
{
    public class PrivateGroup : Group
    {
        public int Id { get; set; }
        public Us Admin { get; set} 
        public List<User> UserList { get; set; }
        
    }

   
}
