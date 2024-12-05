using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//DistributedMemoryCache lets the application to store data from previous requests in the memory of the application.'
//AddSession allows the application to store multiple user requests in the application over a single browser session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(Options =>
{
    Options.IdleTimeout = TimeSpan.FromMinutes(30);
    Options.Cookie.HttpOnly = true;
    Options.Cookie.IsEssential = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //UseSession is what really allows me to store user specific data over multiple requests
    //in a single browers session
    app.UseSession();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseFileServer();

app.MapGet("/", () => Results.Redirect("/index.html"));
app.MapControllers();

app.Run();
