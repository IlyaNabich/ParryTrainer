using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ParryTrainerApi.Contracts.UserProfile;

namespace ParryTrainerApi.Controllers;


[ApiController]
[Route("[controller]")]
public class UserProfileController (IProfilesService profilesService) : ControllerBase
{


    [HttpGet]
    public async Task<ActionResult<UsersProfileResponse>> Get(Guid userId)
    {
        var profile = await profilesService.GetUserProfileAsync(userId);
        
        return Ok(profile);
    }

    [HttpPut]
    public async Task<ActionResult<UsersProfileResponse>> UpdateProfile([FromBody] ProfileRequest request)
    {
        var profileEntity = Profiles.CreateProfile(
            request.userId,
            request.userName,
            request.firstName,
            request.lastName,
            request.age,
            request.links,
            request.region,
            request.country,
            request.description
            );
        
        var profile =  await profilesService.UpdateUserProfileAsync(profileEntity);
        
        return Ok(profile);
    }
}