using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public DbSet<User> TodoItems { get; set; } = null!;
}