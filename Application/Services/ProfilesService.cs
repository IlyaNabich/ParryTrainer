using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class ProfilesService (IProfilesRepository profilesRepository) : IProfilesService
{
    
    public async Task<Profiles> GetUserProfileAsync(Guid userId) =>
        await profilesRepository.GetUserProfileAsync(userId);
    

    public async Task<Guid> CreateUserProfileAsync(Profiles profiles) =>
        await profilesRepository.CreateUserProfileAsync(profiles);
    

    public async Task<Profiles> UpdateUserProfileAsync(Profiles profiles) =>
         await profilesRepository.UpdateUserProfileAsync(profiles);
    
}