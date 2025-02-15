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
List<PostReaction> postReactions = PostReactionObjects.PostReactionsList;
List<Comment> commentsList = CommentData.commentsData;
List<PostTags> postTagsList = PostTagObjects.postTagsList;
List<Reactions> reactionsList = ReactionsObj.reactions;
List<Subscription> subsList = SubscriptionObj.subscriptions;
List<Tags> tagsList = TagsObj.tags;
List<Post> postsList = PostData.postDatas;
List<User> usersList = UserObjects.UserList;


//users Endpoints
app.MapGet("users", () =>
{
    return UserObjects.UserList;
});









//Posts Endpoints

app.MapGet("/posts", () => 
{
  
    return postsList;
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

app.MapGet("/posts/user/{id}", (int id) =>
{
    List<Post> usersPosts = postsList
    .Where(up => up.User_Id == id)
    .ToList();
    return usersPosts;
});

app.MapDelete("/posts/{id}", (int id) =>
{
    Post post = postsList.FirstOrDefault(p => p.Id == id);
    postsList.Remove(post);
    return Results.NoContent();
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


app.MapDelete("/posttags/{id}", (int id) =>
{
    postTagsList.RemoveAll(t => t.Post_Id == id);
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

app.MapPost("/tags", (Tags tag) =>
{
    tag.Id = tagsList.Max(t => t.Id) + 1;
    tagsList.Add(tag);
    return tag;
});

app.MapPut("/tags/{id}", (int id, Tags tag) =>
{
    Tags tagToUpdate = tagsList.FirstOrDefault(st => st.Id == id);
    int tagIndex = tagsList.IndexOf(tagToUpdate);
    if (tagToUpdate == null)
    {
        return Results.NotFound();
    }
    //the id in the request route doesn't match the id from the ticket in the request body. That's a bad request!
    if (id != tag.Id)
    {
        return Results.BadRequest();
    }
    tagsList[tagIndex] = tag;
    return Results.Ok();
});

//Subscriptions Endpoints
app.MapGet("/subscriptions", () =>
{
    return subsList;
});

app.MapGet("/posts/subscriptions/{id}", (int id) =>
{
    List<Post> followersPosts = postsList
    .Where(post => post.User_Id == id)
    .ToList();
    return followersPosts;
});

app.MapPut("/subscriptions/{subscriptionId}/follower/{userId}", (int subscriptionId, int userId) =>
{
    Subscription subscription = subsList.FirstOrDefault(s => s.Id == subscriptionId);

    if (subscription == null)
    {
        return Results.NotFound("Subscription not found.");
    }

    User user = usersList.FirstOrDefault(u => u.Id == userId);

    if (user == null)
    {
        return Results.NotFound("User not found.");
    }

    // Update Follower_Id to match the User's Id
    subscription.Follower_id = user.Id;

    return Results.Ok(subscription);
});

app.MapDelete("/subscriptions/{subscriptionId}", (int subscriptionId) =>
{
    var subscription = subsList.FirstOrDefault(s => s.Id == subscriptionId);

    if (subscription == null)
    {
        return Results.NotFound("Subscription not found.");
    }

    subsList.Remove(subscription);

    return Results.NoContent();
});


app.Run();
