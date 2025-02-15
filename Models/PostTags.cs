namespace RARE;

    public class PostTags
    {
        public int Id { get; set; }
        public int Post_Id { get; set; }
        public int Tag_Id { get; set; }
    }

public class PostTagObjects
{
    public static PostTags postTag1 = new PostTags
    {
        Id = 1000001,
        Post_Id = 1,
        Tag_Id = 2,
    };

    public static PostTags postTag2 = new PostTags
    {
        Id = 1000002,
        Post_Id = 2,
        Tag_Id = 3,
    };

    public static PostTags postTag3 = new PostTags
    {
        Id = 1000003,
        Post_Id = 3,
        Tag_Id = 4,
    };

    public static List<PostTags> postTagsList = new List<PostTags>
        {postTag1, postTag2, postTag3};
}

