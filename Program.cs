using RARE;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// DRY variables
List<Category> categoriesList = CategoryData.categoryData;


//users Endpoints
app.MapGet("users", () =>
{
    return UserObjects.UserList;
});









//Posts Endpoints







//PostReactions Endpoints







//PostTags Endpoints






//Comments Endpoints






//Catagories Endpoints
app.MapGet("/categories", () =>
{
    return CategoryData.categoryData;
});

app.MapPost("/categories", (Category category) =>
{
    category.Id = categoriesList.Max(c => c.Id) + 1;
    categoriesList.Add(category);
    return category;
});




//Reactions Endpoints






//Tags Endpoints







//Subscriptions Endpoints
app.Run();