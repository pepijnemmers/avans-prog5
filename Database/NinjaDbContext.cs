using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NinjaApp.Models;

namespace NinjaApp.Database;

public class NinjaDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // creating seed data //
        var n1 = new Ninja(Guid.NewGuid(), "Shadowstrike Kenji", 2000, []);
        var n2 = new Ninja(Guid.NewGuid(), "Crimson Whisper", 500, []);
        var n3 = new Ninja(Guid.NewGuid(), "Nightwind Taro", 2000, []);
        
        // Head category
        var e1 = new Equipment(Guid.NewGuid(), "Steel Helmet", SlotCategory.Head, 50, 30, 20, 10);
        var e2 = new Equipment(Guid.NewGuid(), "Leather Hood", SlotCategory.Head, 30, 10, -50, 50);
        var e3 = new Equipment(Guid.NewGuid(), "Mystic Crown", SlotCategory.Head, 100, 5, 150, 30);

        // Chest category
        var e4 = new Equipment(Guid.NewGuid(), "Chainmail Armor", SlotCategory.Chest, 120, 80, 40, -10);
        var e5 = new Equipment(Guid.NewGuid(), "Silk Robe", SlotCategory.Chest, 80, 15, 100, 70);
        var e6 = new Equipment(Guid.NewGuid(), "Battle Vest", SlotCategory.Chest, 60, 60, -30, 90);

        // Hand category
        var e7 = new Equipment(Guid.NewGuid(), "Iron Gauntlets", SlotCategory.Hand, 40, 50, 10, 20);
        var e8 = new Equipment(Guid.NewGuid(), "Leather Gloves", SlotCategory.Hand, 25, 15, 5, 100);
        var e9 = new Equipment(Guid.NewGuid(), "Enchanted Gloves", SlotCategory.Hand, 90, 8, 175, 60);

        // Feet category
        var e10 = new Equipment(Guid.NewGuid(), "Steel Boots", SlotCategory.Feet, 50, 40, -100, 30);
        var e11 = new Equipment(Guid.NewGuid(), "Ninja Sandals", SlotCategory.Feet, 30, 10, 30, 200);
        var e12 = new Equipment(Guid.NewGuid(), "Mage Slippers", SlotCategory.Feet, 70, 5, 80, 250);

        // Ring category
        var e13 = new Equipment(Guid.NewGuid(), "Ring of Strength", SlotCategory.Ring, 200, 100, -20, 50);
        var e14 = new Equipment(Guid.NewGuid(), "Ring of Intelligence", SlotCategory.Ring, 180, 5, 200, -25);
        var e15 = new Equipment(Guid.NewGuid(), "Ring of Agility", SlotCategory.Ring, 160, 10, -50, 300);

        // Necklace category
        var e16 = new Equipment(Guid.NewGuid(), "Amulet of Power", SlotCategory.Necklace, 250, 90, 60, 40);
        var e17 = new Equipment(Guid.NewGuid(), "Mystic Necklace", SlotCategory.Necklace, 220, 20, 180, 75);
        var e18 = new Equipment(Guid.NewGuid(), "Pendant of Speed", SlotCategory.Necklace, 190, 5, 70, 280);
        
        modelBuilder.Entity<Ninja>().HasData(n1, n2, n3);
        modelBuilder.Entity<Equipment>().HasData(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18);
    }
}