namespace RARE;

public class User
{
    public int Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public string Bio {  get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime Created_On { get; set; }
    public bool Active { get; set; }
}

public class UserObjects
{
    // User objects
    public static User user1 = new User
    {
        Id = 101, First_Name = "Casey",
        Last_Name = "Cunningham",
        Email = "RealEmail@internet.com",
        Bio = "I like many cheeses",
        Username = "dinnerdoggy",
        Password = "1234",
        Created_On = DateTime.Now,
        Active = true 
    };
    public static User user2 = new User
    {
        Id = 102,
        First_Name = "Matt",
        Last_Name = "Bayes",
        Email = "email@email.com",
        Bio = "Hello!",
        Username = "MattDude",
        Password = "1111",
        Created_On = DateTime.MinValue,
        Active = false
    };
    public static User user3 = new User
    {
        Id = 103,
        First_Name = "Christina",
        Last_Name = "Vieau",
        Email = "google@yahoo.net",
        Bio = "Testing, 1, 2, 3",
        Username = "Christeena14382",
        Password = "2222",
        Created_On = DateTime.Now,
        Active = true
    };

    // List of Users
    public static List<User> UserList = new List<User> { user1, user2, user3 };
}