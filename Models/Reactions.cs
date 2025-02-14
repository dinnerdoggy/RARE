namespace Rare;


public class Reactions
{
    public int Id {get; set;}

    public int Emoji {get; set;}
}

    public class ReactionsObj
    {
        public static Reactions reactions1 = new Reactions
        {
            Id = 10001,
            Emoji = 520001, 
        };

         public static Reactions reactions2 = new Reactions
        {
            Id = 10002,
            Emoji = 20002, 
        };

        public static Reactions reactions3 = new Reactions
        {
            Id = 10003,
            Emoji = 20003, 
        };

        public static List<Reactions> reactions = new List<Reactions> 
        {reactions1, reactions2, reactions3};

    }
