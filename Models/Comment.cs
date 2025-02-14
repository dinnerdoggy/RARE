namespace RARE.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostsId { get; set; }
        public required string content { get; set; }
    }
}
    
    