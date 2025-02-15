
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
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

app.MapGet("/posts", () => 
{
  
    return PostData.postDatas;
});

app.MapGet("/post/{user_id}", (int user_id) => 
{
    var userPosts = PostData.postDatas.FirstOrDefault(p => p.User_Id == user_id);
    if (userPosts == null)
    {
        return Results.NotFound();
    }
        
        return Results.Ok(userPosts);
});




//PostReactions Endpoints







//PostTags Endpoints






//Comments Endpoints

app.MapGet("/comments", () => 
{
    return CommentData.comments;
});

/*app.MapPut("/comment/{id}", (int id, CommentData commentData) => 
{
   CommentData commentToUpdate = CommentData.comments.FirstOrDefault(c => c.Id == id);
   //int commentIndex = CommentData.commentsData.IndexOf(commentToUpdate);
    if (commentToUpdate == null)
    {
        return Results.NotFound();
    }
    
     int commentIndex = CommentData.comments.IndexOf(commentToUpdate);

    if (id != CommentData.Id)
    {
        return Results.BadRequest();
    }
    CommentData.comments[commentIndex] = commentToUpdate;
        return Results.Ok(commentToUpdate);
});*/


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

app.MapGet("/tags", () => 
{
    return TagsObj.tags;
});





//Subscriptions Endpoints


app.Run();
