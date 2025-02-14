namespace RARE.Models;

    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public required string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public required string Content { get; set; }
        public Boolean Approved { get; set; }
    }

public class PostData
{
    List<Post> postDatas = new List<Post>
    {
        new Post
        {
            Id = 1,
            UserId = 101,
            CategoryId = 5,
            Title = "The Rise of AI: A New Era",
            PublicationDate = new DateTime(2025, 2, 10),
            Content = "Artificial Intelligence is changing the world. In this article, we explore the potential impact of AI on industries and daily life...",
            Approved = true
        }
    };
}
