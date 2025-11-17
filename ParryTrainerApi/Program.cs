using Application.Auth;
using Application.Services;
using Core.Abstractions;
using Core.Interfaces;
using DataAccess;
using DataAccess.Repository;
using Infrastructure;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IUsersProfilesRepository, UsersProfilesRepository>();
builder.Services.AddScoped<IUsersProfilesService, UsersProfilesService>();
builder.Services.AddScoped<IUsersStatsRepository, UsersStatsRepository>();
builder.Services.AddScoped<IUsersStatsService, UsersStatsService>();
builder.Services.AddScoped<IUserService, UsersService>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddDbContext<ParryTrainerDbContext>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(ParryTrainerDbContext)));
    });




var app = builder.Build();

app.UseCors("AllowAll");

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();

app.Run();