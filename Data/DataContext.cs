using CardManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CardManager.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Card> Cards { get; set; }
}