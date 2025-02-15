namespace RARE;

public class Comment
{
    public int Id { get; set; }
    public int Author_Id { get; set; }
    public int Post_Id { get; set; }
    public required string Content { get; set; }
}

public class CommentData
{
    public static List<Comment> commentsData = new List<Comment>
    {
        new Comment
        {   Id = 600,
            Author_Id = 101,
            Post_Id = 1,
            Content = "Interesting Article"
         },
        new Comment
        {   Id = 602,
            Author_Id = 102,
            Post_Id = 5,
            Content = "I am going there someday"
        },
        new Comment
        {
            Id = 602,
            Author_Id = 101,
            Post_Id = 5,
            Content = "I've been there, pretty amazing"
        },
        new Comment
        {
            Id = 603,
            Author_Id = 103,
            Post_Id = 5,
            Content = "On my way there now"

        },
        new Comment
        {
            Id = 604,
            Author_Id = 102,
            Post_Id = 6,
            Content = "It will be interesting to see if Blockchain technology will really transform it to this degree"
        },
        new Comment
        {
            Id = 605,
            Author_Id = 103,
            Post_Id = 2,
            Content = "We need some articles about kittens"
        }

    };
}
