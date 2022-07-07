namespace ChatApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string HashPassword { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }


        


    }
}
