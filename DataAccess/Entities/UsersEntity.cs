namespace DataAccess.Entities;

public class UsersEntity
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }
    
    public ProfilesEntity ProfilesEntity { get; set; }
    
    public StatsEntity StatsEntity { get; set; }
    
    public DateTime RegDate { get; set; }
    
    public DateTime LastOnlineDate { get; set; }
    
}