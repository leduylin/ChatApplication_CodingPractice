namespace ChatApplication.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IFormFile FormFile { get; set; }

    }
}
