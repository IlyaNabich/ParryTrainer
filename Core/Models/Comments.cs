namespace Core.Models;

public class Comments
{
    public Guid UserId { get; }
    
    public string UserName { get; }
    
    public string Comment { get; }
    
    public DateTime DateCreated { get; } 
    
    
}