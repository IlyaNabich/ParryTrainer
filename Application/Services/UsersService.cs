using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersService (IUsersRepository usersRepository) : IUserService
{
    private readonly IUsersRepository _usersRepository = usersRepository;
    public async Task<List<Users>> GetAllUsers()
    {
        return await _usersRepository.Get();
    }

    public async Task<Guid> CreateUser(Users users)
    {
        return await _usersRepository.Create(users);
    }

    public async Task<Guid> UpdateUser(Guid userId, string login, string password, string userName)
    {
        return await _usersRepository.Update(userId, login, password, userName);
    }

    public async Task<Guid> DeleteUser(Guid userId)
    {
        return await _usersRepository.Delete(userId);
    }
}