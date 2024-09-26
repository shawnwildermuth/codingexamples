using ComposingLinq.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComposingLinq.Data;

public class ProductContext : DbContext
{
  public DbSet<Order> Orders { get; set; }
  public DbSet<OrderItem> OrderItems { get; set; }
  public DbSet<Product> Products { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Database=ShoeMoneyDb;Integrated Security=true;");
  }
}