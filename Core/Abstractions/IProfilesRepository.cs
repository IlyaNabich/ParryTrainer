using Core.Models;

namespace Core.Abstractions;

public interface IProfilesRepository
{
    public Task<Profiles> GetUserProfileAsync(Guid userId);
    
    public Task<Guid> CreateUserProfileAsync(Profiles profiles);
    
    public Task<Profiles> UpdateUserProfileAsync(Profiles profiles);
    
}