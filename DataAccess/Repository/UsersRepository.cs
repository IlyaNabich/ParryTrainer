

using Core.Abstractions;
using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class UsersRepository (ParryTrainerDbContext context) : IUsersRepository
{
    private readonly ParryTrainerDbContext _context = context;
    public async Task<List<Users>> Get()
    
    {
        var userEntities = await _context.Users
            .AsNoTracking()
            .ToListAsync();
        var user = userEntities
            .Select(x => Users.CreateUsers(x.UserId, x.UserName, x.Login, x.Password, x.RegDate, x.LastOnlineDate).user)
            .ToList();
        return user;
    }

    public async Task<Guid> Create(Users users)
    {
        var userEntity = new UsersEntity
        {
            UserId = users.UserId,
            UserName = users.UserName,
            Login = users.Login,
            Password = users.Password,
            RegDate = users.RegDate,
            LastOnlineDate = users.LastOnlineDate
        };
        await _context.Users.AddAsync(userEntity);
        await _context.SaveChangesAsync();
        
        return users.UserId;
    }

    public async Task<Guid> Update(Guid userId, string login, string password, string userName)
    {
        await _context.Users.Where(x => x.UserId == userId).ExecuteUpdateAsync(s => s
            .SetProperty(x => x.Login, login)
            .SetProperty(x => x.Password, password)
            .SetProperty(x => x.UserName, userName));
        
        return userId;
    }

    public async Task<Guid> Delete(Guid userId)
    {
        await _context.Users
            .Where(x => x.UserId == userId)
            .ExecuteDeleteAsync<UsersEntity>();
        
        return userId;
    }
}
