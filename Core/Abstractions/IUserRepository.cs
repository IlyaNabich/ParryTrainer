using Core.Models;

namespace Core.Abstractions;

public interface IUserRepository
{
    public Task<List<User>> Get();

    public Task<string?> Create();
    
    public Task<string?> Update();
    
    public Task<string?> Delete();
}