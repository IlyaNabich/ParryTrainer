using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ParryTrainerDbContext>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(ParryTrainerDbContext)));
    });




var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();