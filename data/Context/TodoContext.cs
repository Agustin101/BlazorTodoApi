using authWebApi.data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace authWebApi.Context.data;

public class TodoContext : IdentityDbContext
{
  public TodoContext(DbContextOptions<TodoContext> options)
  : base(options)
  {
  }

  public DbSet<TodoItem> TodoItems { get; set; }
  public DbSet<TodoUser> TodoUsers { get; set; }
}