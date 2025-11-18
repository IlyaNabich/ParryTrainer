using Core.Models;

namespace Core.Abstractions;

public interface IStatsRepository
{
    public Task<Stats> Get (Guid userId);

    public Task<Guid> Create(Stats stats);
    
    public Task<Guid> Update(Guid userId, Stats stats);
    
    public Task<Guid> Clear (Guid userId);
}