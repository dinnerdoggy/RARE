namespace RARE;

public class Category
{
    public int Id { get; set; }
    public required string Label { get; set; }
}
public class CategoryData
{
    List<Category> categoryData = new List<Category>
    {
        new Category
        {
            Id = 501,
            Label = "Technology"
        },
        new Category
        {
            Id = 502,
            Label = "Energy"
        },
        new Category
        {
            Id = 503,
            Label = "Social Media"
        },
        new Category
        {
            Id = 504,
            Label = "Science"
        },
        new Category
        {
            Id = 505,
            Label = "Finances"
        }
    };
}
  