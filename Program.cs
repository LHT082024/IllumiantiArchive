var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  // Session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Enable CORS to allow requests from any origin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()  // Allow any origin
               .AllowAnyMethod()  // Allow all HTTP methods (GET, POST, etc.)
               .AllowAnyHeader()); // Allow all headers
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Use session and Swagger in development mode
    app.UseSession();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");  // Enable CORS


// Serve static files if needed (for example, index.html)
app.UseFileServer();

// Map controllers
app.MapControllers();

// Set a default route to redirect to your frontend
app.MapGet("/", () => Results.Redirect("/swagger"));



// Run the application
app.Run(); void ConfigureServices(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("http://localhost:5118/") // Your frontend's origin
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
    });

    services.AddControllers();
}

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    app.UseRouting();
    app.UseAuthorization();
    app.UseCors(); // Enable CORS
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
