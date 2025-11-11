using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersStatsService (IUsersStatsRepository usersStatsRepository) : IUsersStatsService
{
    private readonly IUsersStatsRepository _usersStatsRepository = usersStatsRepository;
    public async Task<UsersStats> GetUserStats(Guid userId)
    {
        return await _usersStatsRepository.Get(userId);
    }

    public async Task<Guid> CreateUserStats(UsersStats userStats)
    {
        return await _usersStatsRepository.Create(userStats);
    }

    public async Task<Guid> UpdateUserStats(Guid userId, UsersStats userStats)
    {
        return await _usersStatsRepository.Update(userId, userStats);
    }

    public async Task<Guid> ClearUserStats(Guid userId)
    {
        return await _usersStatsRepository.Clear(userId);
    }
}