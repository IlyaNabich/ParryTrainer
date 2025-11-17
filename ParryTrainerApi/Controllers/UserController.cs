using Application.Auth;
using Core.Abstractions;
using Core.Models;
using Core.Interfaces;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using ParryTrainerApi.Contracts.User;

namespace ParryTrainerApi.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController (IUserService userService, IUsersProfilesService usersProfilesService, IUsersStatsService usersStatsService, IPasswordHasher passwordHasher) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<UserResponse>> GetUser()
    {
        var user = await userService.GetAllUsers();

        var response = user.Select(x => new UserResponse(x.UserId, x.UserName, x.LastOnlineDate, x.RegDate));
        
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<UserResponse>> CreateUser([FromBody] UserRequest request)
    {
        var id = Guid.NewGuid();
        var (user,error) = Users.CreateUsers(
            id,
            request.Username,
            request.Login,
            passwordHasher.Generate(request.Password),
            DateTime.UtcNow, 
            DateTime.UtcNow
            );
        var profile = UsersProfiles.CreateProfile(
            id,
            request.Username,
            "Unknown",
            "Unknown",
            "Unknown",
            "Unknown",
            "Unknown",
            "Unknown",
            "Unknown"
        );
        var stat = UsersStats.CreateStats(id);
        if (string.IsNullOrEmpty(error))
        {
            return BadRequest(error);
        }

        var users = await userService.CreateUser(user);
        await usersStatsService.CreateUserStats(stat);
        await usersProfilesService.CreateUserProfileAsync(profile);
        return Ok(users);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateUser([FromBody] UserRequest request, Guid userId)
    {
        var user = await userService.UpdateUser(userId, request.Login, request.Password, request.Username);
        
        return Ok(user);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteUser(Guid userId)
    {
        var user = await userService.DeleteUser(userId);
        
        return Ok(user);
    }
}