namespace RARE;

public class Tags
{
    public int Id {get; set;}

    public string Label {get; set;}

}

    public class TagsObj
    {
        public static Tags tags1 = new Tags
        {
            Id = 1000001,
            Label = "Read",
        };

         public static Tags tags2 = new Tags
        {
            Id = 1000002,
            Label = "Responded",
        };

         public static Tags tags3 = new Tags
        {
            Id = 1000003,
            Label = "Unread",
        };

        public static List<Tags> tags = new List<Tags> 
        {tags1, tags2, tags3};
    }
