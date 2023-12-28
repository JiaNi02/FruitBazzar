using FruitBazzar1.Api;
using FruitBazzar1.Api.Controllers.ChatHub;
using FruitBazzar1.Api.Entities;
using FruitBazzar1.Api.Functions.Message;
using FruitBazzar1.Api.Functions.UserFriend;
using FruitBazzar1.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSignalR();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FruitBazzardatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddTransient<IUserFunction, UserFunction>();
//builder.Services.AddTransient<IUserFriendFunction, UserFriendFunction>();
//builder.Services.AddTransient<IMessageFunction, MessageFunction>();
//builder.Services.AddScoped<UserOperator>();
//builder.Services.AddScoped<ChatHub>();

//builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseRouting();

app.UseMiddleware<JwtMiddleware>();

//app.UseAuthorization();

//app.MapControllers();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//    endpoints.MapHub<ChatHub>("/ChatHub");
//});

app.Run();
