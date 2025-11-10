using Core.Models;

namespace Core.Interfaces;

public interface IUsersProfilesService
{
    public Task<UsersProfiles> GetUserProfileAsync(Guid userId);
    
    public Task<Guid> CreateUserProfileAsync(UsersProfiles usersProfiles);
    
    public Task<UsersProfiles> UpdateUserProfileAsync(UsersProfiles usersProfiles);
}