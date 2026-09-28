using BaiTapBuoi5.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapBuoi5.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}
