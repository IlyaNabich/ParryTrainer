using Core.Validations;

namespace Core.Models;

public class Users
{
    
    private Users(Guid userId, string userName, string login, string password, DateTime regDate, DateTime lastOnlineDate)
    {
        UserId = userId;
        UserName = userName;
        Login = login;
        Password = password;
        RegDate = regDate;
        LastOnlineDate = lastOnlineDate;
    }
    
    public Guid UserId { get; }

    public string UserName { get; }

    public string Login { get; }
    
    public string Password { get; }
    
    public DateTime RegDate { get; }
    
    public DateTime LastOnlineDate { get; }

    public static (Users user, string Error) CreateUsers(Guid userId, string userName, string login, string password,  DateTime regDate, DateTime lastOnlineDate)
    {
        var error = Validation.UserValidate(login, password, userName);
        var user = new Users(userId, userName, login, password, regDate, lastOnlineDate);
        return (user,error);
    }
}