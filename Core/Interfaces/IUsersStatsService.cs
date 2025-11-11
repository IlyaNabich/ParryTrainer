using Core.Models;

namespace Core.Interfaces;

public interface IUsersStatsService
{
    public Task<UsersStats> GetUserStats(Guid userId);

    public Task<Guid> CreateUserStats(UsersStats userStats);
    
    public Task<Guid> UpdateUserStats(Guid userId, UsersStats userStats);
    
    public Task<Guid> ClearUserStats(Guid userId);
}