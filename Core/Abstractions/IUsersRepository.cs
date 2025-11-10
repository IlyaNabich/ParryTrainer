using Core.Models;


namespace Core.Abstractions;

public interface IUsersRepository
{
    public Task<List<Users>> Get();

    public Task<Guid> Create(Users users);

    public Task<Guid> Update(Guid userId, string login, string password, string userName);
    
    public Task<Guid> Delete(Guid userId);
}