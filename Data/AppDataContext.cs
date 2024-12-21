using Microsoft.EntityFrameworkCore;
using SiteBlazorServer.Models;

namespace SiteBlazorServer.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}