using Core.Models;

namespace Core.Abstractions;

public interface IUsersProfilesRepository
{
    public Task<UsersProfiles> GetUserProfileAsync(Guid userId);
    
    public Task<Guid> CreateUserProfileAsync(UsersProfiles usersProfiles);
    
    public Task<UsersProfiles> UpdateUserProfileAsync(UsersProfiles usersProfiles);
    
}