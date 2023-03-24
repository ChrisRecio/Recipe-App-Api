using Microsoft.EntityFrameworkCore;
using Recipe_App_Api;
using Recipe_App_Api.Data;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<Seed>(); // Populate DB with mock data

// Map Interfaces and Repositories
builder.Services.AddScoped<IRecipeInterface, RecipeRepository>();
builder.Services.AddScoped<IIngredientInterface, IngredientRepository>();
builder.Services.AddScoped<IRecipeStepInterface, RecipeStepRepository>();

// Map AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    // Desktop
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

    // Laptop
    //options.UseSqlServer(builder.Configuration.GetConnectionString("LaptopDefaultConnection"));
});

var app = builder.Build();

// Populate database with mock data (seed.cs)
if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
