namespace Rare;

public class Subscription 
{
    public int Id {get; set;}

    public int Follower_id {get; set;}

    public int Author_id {get; set;}

    public DateTime Created_on {get; set;}
}

  

public class SubscriptionObj 
{
    public static Subscription subscription1 = new Subscription
    {
        Id = 1001,
        Follower_id = 2001,
        Author_id = 3001,
        Created_on = DateTime.Now,
    };

    public static Subscription subscription2 = new Subscription
    {
        Id = 1002,
        Follower_id = 2002,
        Author_id = 3002,
        Created_on = DateTime.Now,
    };

    public static Subscription subscription3 = new Subscription
    {
        Id = 1003,
        Follower_id = 2003,
        Author_id = 3003,
        Created_on = DateTime.Now,
    };

     public static List<Subscription> subscriptions = new List<Subscription>  
     {subscription1, subscription2, subscription3};
    
       
    


}
