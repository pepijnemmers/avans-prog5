using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;

namespace NinjaApp.Database;

public class NinjaDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Order> Orders { get; set; }
}