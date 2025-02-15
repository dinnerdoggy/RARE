
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






//PostReactions Endpoints







//PostTags Endpoints






//Comments Endpoints

app.MapGet("/comments", () => 
{
    
});




//Catagories Endpoints







//Reactions Endpoints






//Tags Endpoints







//Subscriptions Endpoints


app.Run();
