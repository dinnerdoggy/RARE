
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




//users Endpoints

app.MapGet("/users", () => 
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
    return CommentData.commentsData;
});




//Catagories Endpoints







//Reactions Endpoints






//Tags Endpoints

app.MapGet("/tags", () => 
{
    return TagsObj.tags;
});





//Subscriptions Endpoints


app.Run();
