using Microsoft.AspNetCore.Identity;
namespace authWebApi.data.Models;

public class TodoUser : IdentityUser
{
  public bool AddTodoAllowed { get; set; }
  public required ICollection<TodoItem> Reviews { get; set; }
  public string? RefreshToken { get; set; }
  public DateTime RefreshTokenExpiry { get; set; }
}