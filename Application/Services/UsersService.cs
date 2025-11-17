using Core.Abstractions;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class UsersService (IUsersRepository usersRepository) : IUserService
{

    public async Task<List<Users>> GetAllUsers() =>
        await usersRepository.Get();
    

    public async Task<Guid> CreateUser(Users users) =>
        await usersRepository.Create(users);
    

    public async Task<Guid> UpdateUser(Guid userId, string login, string password, string userName) =>
        await usersRepository.Update(userId, login, password, userName);
    

    public async Task<Guid> DeleteUser(Guid userId) =>
        await usersRepository.Delete(userId);
    
}