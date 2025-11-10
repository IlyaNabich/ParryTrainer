using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersProfilesService (IUsersProfilesRepository usersProfilesRepository) : IUsersProfilesService
{
    private readonly IUsersProfilesRepository _usersProfilesRepository = usersProfilesRepository;
    
    public async Task<UsersProfiles> GetUserProfileAsync(Guid userId)
    {
       return await _usersProfilesRepository.GetUserProfileAsync(userId);
    }

    public async Task<Guid> CreateUserProfileAsync(UsersProfiles usersProfiles)
    {
        return await _usersProfilesRepository.CreateUserProfileAsync(usersProfiles);
    }

    public async Task<UsersProfiles> UpdateUserProfileAsync(UsersProfiles usersProfiles)
    {
        return await _usersProfilesRepository.UpdateUserProfileAsync(usersProfiles);
    }
}