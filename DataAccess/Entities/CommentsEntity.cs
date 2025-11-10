namespace DataAccess.Entities;

public class CommentsEntity
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; }
    
    public string Comment { get; set; }
    
    public DateTime DateCreated { get; set; } 
    
    public UsersProfilesEntity UsersProfilesEntity { get; set; }
}