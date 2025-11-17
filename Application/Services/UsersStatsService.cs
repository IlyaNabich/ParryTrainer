using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersStatsService (IUsersStatsRepository usersStatsRepository) : IUsersStatsService
{

    public async Task<UsersStats> GetUserStats(Guid userId) => 
        await usersStatsRepository.Get(userId);
    

    public async Task<Guid> CreateUserStats(UsersStats userStats) =>
        await usersStatsRepository.Create(userStats);
    

    public async Task<Guid> UpdateUserStats(Guid userId, UsersStats userStats) =>
        await usersStatsRepository.Update(userId, userStats);
    

    public async Task<Guid> ClearUserStats(Guid userId) => 
        await usersStatsRepository.Clear(userId);
    
}