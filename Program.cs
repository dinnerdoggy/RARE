using RARE;
using System.Xml.Linq;

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
List<PostReaction> postReactions = PostReactionObjects.PostReactionsList;
List<Comment> commentsList = CommentData.commentsData;
List<PostTags> postTagsList = PostTagObjects.postTagsList;
List<Reactions> reactionsList = ReactionsObj.reactions;
List<Subscription> subsList = SubscriptionObj.subscriptions;
List<Post> postList = PostData.postDatas;


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

app.MapPost("/posts", (Post post) =>
{
    post.Id = postList.Max(p => p.Id) +1;
    postList.Add(post);
    return post;
});

app.MapPut("/posts/{id}", (int id, Post post) =>
{
    Post postToUpdate =
    postList.FirstOrDefault(p => p.Id == id);
    int postIndex = postList.IndexOf(postToUpdate);
    if (postToUpdate == null)
    {
        return Results.NotFound();
    }
    postList[postIndex] =
    post;
    return Results.Ok();
});

//PostReactions Endpoints
app.MapGet("/postreactions", () =>
{
    return postReactions;
});






//PostTags Endpoints
app.MapGet("/posttags", () =>
{
    return postTagsList;
});





//Comments Endpoints

app.MapGet("/comments", () => 
{
    return CommentData.commentsData;
});

app.MapPost("/comments", (Comment comment) =>
{
    comment.Id = commentsList.Max(c => c.Id) + 1;
    commentsList.Add(comment);
    return comment;
});

app.MapDelete("/comments/{id}", (int id) =>
{ 
    Comment comment =
    commentsList.Find(c => c.Id == id);
    if (comment == null)
    {
        return Results.NotFound();
    }
    commentsList.Remove(comment);
    return Results.Ok();
});


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
app.MapGet("/reactions", () =>
{
    return reactionsList;
});





//Tags Endpoints

app.MapGet("/tags", () => 
{
    return TagsObj.tags;
});





//Subscriptions Endpoints
app.MapGet("/subscriptions", () =>
{
    return subsList;
});


app.Run();
