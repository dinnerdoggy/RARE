namespace RARE;

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
    public static List<Post> postDatas = new List<Post>
    {
        new Post
        {
            Id = 1,
            UserId = 101,
            CategoryId = 501,
            Title = "The Rise of AI: A New Era",
            PublicationDate = new DateTime(2025, 2, 10),
            Content = "Artificial Intelligence is changing the world. In this article, we explore the potential impact of AI on industries and daily life...",
            Approved = true
        },
        new Post
        {
            Id = 2,
            UserId = 102,
            CategoryId = 502,
            Title = "Exploring the Future of Renewable Energy",
            PublicationDate = new DateTime(2025, 2, 12),
            Content = "Renewable energy sources are becoming more critical than ever. This article dives into the innovations that are shaping the energy sector for a sustainable future...",
            Approved = true

        },
        new Post
        {
            Id = 3,
            UserId = 103,
            CategoryId = 503,
            Title = "The Evolution of Social Media: What's Next?",
            PublicationDate = new DateTime(2025, 2, 13),
            Content = "Social media platforms are evolving at a rapid pace. In this piece, we examine the changing dynamics of online communication and what we can expect in the future...",
            Approved = true
        },
        new Post
        {
            Id = 4,
            UserId = 101,
            CategoryId = 504,
            Title = "The Impact of Climate Change on Global Agriculture",
            PublicationDate = new DateTime(2025, 2, 14),
            Content = "Climate change is wreaking havoc on global food production. This article looks at the challenges farmers face and the strategies being developed to adapt to the shifting climate...",
            Approved = true

        },
        new Post
        {
            Id = 5,
            UserId = 102,
            CategoryId = 505,
            Title = "The Future of Space Exploration: Beyond Earth",
            PublicationDate = new DateTime(2025, 2, 15),
            Content = "Space exploration is entering a new phase, with missions set to explore the Moon, Mars, and beyond. This article delves into the exciting prospects of humanity's future in space...",
            Approved = true

        },
        new Post
        {
            Id = 6,
            UserId = 102,
            CategoryId = 505,
            Title = "Blockchain: Revolutionizing Financial Systems",
            PublicationDate = new DateTime(2025, 2, 16),
            Content = "Blockchain technology is transforming the way we think about money and financial systems. In this article, we explore the applications and potential of blockchain in various industries...",
            Approved = true
        }

    };
}
