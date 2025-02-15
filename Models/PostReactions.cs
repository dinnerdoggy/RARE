namespace RARE;

public class PostReaction
{
    public int Id { get; set; }
    public int Reaction_Id { get; set; } // will have to connect once all classes exist
    public int User_Id { get; set; } // will have to connect once all classes exist
    public int Post_Id { get; set; } // will have to connect once all classes exist

}

public class PostReactionObjects
{
    // Reaction Objects
    public static PostReaction Reaction1 = new PostReaction
    {
        Id = 2001,
        Reaction_Id = 10001,
        User_Id = 2,
        Post_Id = 3
    };
    public static PostReaction Reaction2 = new PostReaction
    {
        Id = 2002,
        Reaction_Id = 10002,
        User_Id = 3,
        Post_Id = 4
    };
    public static PostReaction Reaction3 = new PostReaction
    {
        Id = 2002,
        Reaction_Id = 10003,
        User_Id = 3,
        Post_Id = 4
    };

    // List of Reactions
    public static List<PostReaction> PostReactionsList = new List<PostReaction>
    {
        Reaction1, Reaction2, Reaction3
    };
}