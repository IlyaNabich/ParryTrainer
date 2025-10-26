using DataAccess.Entities;

namespace Core.Models;

public class User
{
    private User(Guid userId, string userName, string login, string password, UserStat userStat)
    {
        UserId = userId;
        UserName = userName;
        Login = login;
        Password = password;
        UserStat = userStat;
    }
    
    public Guid UserId { get; }

    public string UserName { get; }

    public string Login { get; }
    
    public string Password { get; }
    
    public UserStat UserStat { get; }

    public static (User User, string Error) CreateUser(Guid id, string userName, string login, string password, UserStat userStat)
    {
        var error = string.Empty;
        var userId = Guid.NewGuid();
        var user = new User(userId, userName, login, password, userStat);
        return (user, error);
    }
}