using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;

namespace NinjaApp.Database;

public class NinjaDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /* creating seed data */
        modelBuilder.Entity<Ninja>().HasData(
            new Ninja(Guid.NewGuid(), "Shadowstrike Kenji", 2000, []),
            new Ninja(Guid.NewGuid(), "Crimson Whisper", 500, []),
            new Ninja(Guid.NewGuid(), "Nightwind Taro", 2000, [])
        );

        modelBuilder.Entity<Equipment>().HasData(
            // Head category
            new Equipment(Guid.NewGuid(), "Steel Helmet", SlotCategory.Head, 50, 30, 20, 10),
            new Equipment(Guid.NewGuid(), "Leather Hood", SlotCategory.Head, 30, 10, -50, 50),
            new Equipment(Guid.NewGuid(), "Mystic Crown", SlotCategory.Head, 100, 5, 150, 30),

            // Chest category
            new Equipment(Guid.NewGuid(), "Chainmail Armor", SlotCategory.Chest, 120, 80, 40, -10),
            new Equipment(Guid.NewGuid(), "Silk Robe", SlotCategory.Chest, 80, 15, 100, 70),
            new Equipment(Guid.NewGuid(), "Battle Vest", SlotCategory.Chest, 60, 60, -30, 90),

            // Hand category
            new Equipment(Guid.NewGuid(), "Iron Gauntlets", SlotCategory.Hand, 40, 50, 10, 20),
            new Equipment(Guid.NewGuid(), "Leather Gloves", SlotCategory.Hand, 25, 15, 5, 100),
            new Equipment(Guid.NewGuid(), "Enchanted Gloves", SlotCategory.Hand, 90, 8, 175, 60),

            // Feet category
            new Equipment(Guid.NewGuid(), "Steel Boots", SlotCategory.Feet, 50, 40, -100, 30),
            new Equipment(Guid.NewGuid(), "Ninja Sandals", SlotCategory.Feet, 30, 10, 30, 200),
            new Equipment(Guid.NewGuid(), "Mage Slippers", SlotCategory.Feet, 70, 5, 80, 250),

            // Ring category
            new Equipment(Guid.NewGuid(), "Ring of Strength", SlotCategory.Ring, 200, 100, -20, 50),
            new Equipment(Guid.NewGuid(), "Ring of Intelligence", SlotCategory.Ring, 180, 5, 200, -25),
            new Equipment(Guid.NewGuid(), "Ring of Agility", SlotCategory.Ring, 160, 10, -50, 300),

            // Necklace category
            new Equipment(Guid.NewGuid(), "Amulet of Power", SlotCategory.Necklace, 250, 90, 60, 40),
            new Equipment(Guid.NewGuid(), "Mystic Necklace", SlotCategory.Necklace, 220, 20, 180, 75),
            new Equipment(Guid.NewGuid(), "Pendant of Speed", SlotCategory.Necklace, 190, 5, 70, 280)
        );
    }
}