using System.ComponentModel.DataAnnotations.Schema;

namespace RARE;

    public class Post
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Category_Id { get; set; }
        public required string Title { get; set; }
        public DateTime Publication_Date { get; set; }
        public required string Content { get; set; }
        public Boolean Approved { get; set; }

    // Reference to Category (not stored in DB)
    public Category? Category => CategoryData.GetCategoryById(Category_Id);
    }

public class PostData
{
    //public static void AddPost(Post post)
    //{
    //    postDatas.Add(post);

    //    // Find the matching category and add this post to its list
    //    var category = CategoryData.GetCategoryById(post.Category_Id);
    //    category?.Posts.Add(post);
    //}

    public static List<Post> postDatas = new List<Post>
    {
        new Post
        {
            Id = 1,
            User_Id = 101,
            Category_Id = 501,
            Title = "The Rise of AI: A New Era",
            Publication_Date = new DateTime(2025, 2, 10),
            Content = "Artificial Intelligence is changing the world. In this article, we explore the potential impact of AI on industries and daily life...",
            Approved = true
        },
        new Post
        {
            Id = 2,
            User_Id = 102,
            Category_Id = 502,
            Title = "Exploring the Future of Renewable Energy",
            Publication_Date = new DateTime(2025, 2, 12),
            Content = "Renewable energy sources are becoming more critical than ever. This article dives into the innovations that are shaping the energy sector for a sustainable future...",
            Approved = true

        },
        new Post
        {
            Id = 3,
            User_Id = 103,
            Category_Id = 502,
            Title = "The Evolution of Social Media: What's Next?",
            Publication_Date = new DateTime(2025, 2, 13),
            Content = "Social media platforms are evolving at a rapid pace. In this piece, we examine the changing dynamics of online communication and what we can expect in the future...",
            Approved = true
        },
        new Post
        {
            Id = 4,
            User_Id = 101,
            Category_Id = 504,
            Title = "The Impact of Climate Change on Global Agriculture",
            Publication_Date = new DateTime(2025, 2, 14),
            Content = "Climate change is wreaking havoc on global food production. This article looks at the challenges farmers face and the strategies being developed to adapt to the shifting climate...",
            Approved = true
        },
        new Post
        {
            Id = 5,
            User_Id = 102,
            Category_Id = 505,
            Title = "The Future of Space Exploration: Beyond Earth",
            Publication_Date = new DateTime(2025, 2, 15),
            Content = "Space exploration is entering a new phase, with missions set to explore the Moon, Mars, and beyond. This article delves into the exciting prospects of humanity's future in space...",
            Approved = true

        },
        new Post
        {
            Id = 6,
            User_Id = 102,
            Category_Id = 505,
            Title = "Blockchain: Revolutionizing Financial Systems",
            Publication_Date = new DateTime(2025, 2, 16),
            Content = "Blockchain technology is transforming the way we think about money and financial systems. In this article, we explore the applications and potential of blockchain in various industries...",
            Approved = true
        },

        new Post 
        {
             Id = 7,
            User_Id = 102,
            Category_Id = 505,
            Title = "Blockchain: Revolutionizing Financial Systems",
            Publication_Date = new DateTime(2025, 2, 16),
            Content = "Blockchain technology is transforming the way we think about money and financial systems. In this article, we explore the applications and potential of blockchain in various industries...",
            Approved = true
        }

    };

    internal static object? FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }

    internal static List<Post> Where(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
