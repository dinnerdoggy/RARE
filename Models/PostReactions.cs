namespace RARE;

public class PostReaction
{
    public int Id { get; set; }
    public int Reaction_Id { get; set; } // will have to connect once all classes exist
    public int User_Id { get; set; } // will have to connect once all classes exist
    public int Post_Id { get; set; } // will have to connect once all classes exist

}

//public class PostReactionObjects
//{
//    public static PostReaction Reaction1 = new PostReaction
//    {
//        Id = 2001,
//        Reaction_Id = 1,
//        User_Id = 2,
//        Post_Id = 3
//    };
//    public static PostReaction Reaction2 = new PostReaction 
//    { 
//    }
//}