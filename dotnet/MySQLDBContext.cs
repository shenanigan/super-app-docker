using Microsoft.EntityFrameworkCore;

namespace dotnet;
public class MySQLDBContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Job> Job { get; set; }
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) { }
}