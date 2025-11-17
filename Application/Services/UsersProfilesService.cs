using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersProfilesService (IUsersProfilesRepository usersProfilesRepository) : IUsersProfilesService
{
    
    public async Task<UsersProfiles> GetUserProfileAsync(Guid userId) =>
        await usersProfilesRepository.GetUserProfileAsync(userId);
    

    public async Task<Guid> CreateUserProfileAsync(UsersProfiles usersProfiles) =>
        await usersProfilesRepository.CreateUserProfileAsync(usersProfiles);
    

    public async Task<UsersProfiles> UpdateUserProfileAsync(UsersProfiles usersProfiles) =>
         await usersProfilesRepository.UpdateUserProfileAsync(usersProfiles);
    
}