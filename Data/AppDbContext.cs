using Microsoft.EntityFrameworkCore;

namespace IDONOTKNOW.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}