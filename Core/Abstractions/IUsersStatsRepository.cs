using Core.Models;

namespace Core.Abstractions;

public interface IUsersStatsRepository
{
    public Task<UsersStats> Get (Guid userId);

    public Task<Guid> Create(UsersStats userStats);
    
    public Task<Guid> Update(Guid userId, UsersStats usersStats);
    
    public Task<Guid> Clear (Guid userId);
}