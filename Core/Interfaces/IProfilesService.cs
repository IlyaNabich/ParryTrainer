using Core.Models;

namespace Core.Interfaces;

public interface IProfilesService
{
    public Task<Profiles> GetUserProfileAsync(Guid userId);
    
    public Task<Guid> CreateUserProfileAsync(Profiles profiles);
    
    public Task<Profiles> UpdateUserProfileAsync(Profiles profiles);
}