using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NinjaApp.Models;
using NinjaApp.Models.Enums;

namespace NinjaApp.Database;

public class NinjaDbContext : DbContext
{
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    
    private IConfiguration Configuration => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
    
    public NinjaDbContext()
    {
    }

    public NinjaDbContext(DbContextOptions<NinjaDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ** creating seed data ** //
        // Ninjas
        var n1 = new Ninja() { Id = Guid.NewGuid(), Name = "Shadowstrike Kenji", Gold = 2000, Inventory = [] };
        var n2 = new Ninja() { Id = Guid.NewGuid(), Name = "Crimson Whisper", Gold = 500, Inventory = [] };
        var n3 = new Ninja() { Id = Guid.NewGuid(), Name = "Nightwind Taro", Gold = 2000, Inventory = [] };
        
        modelBuilder.Entity<Ninja>().HasData(n1, n2, n3);
        
        // Head category
        var e1 = new Equipment() { Id = Guid.NewGuid(), Name = "Steel Helmet",  Category = SlotCategory.Head, Price = 50, Strength = 30, Intelligence = 20,  Agility = 10 };
        var e2 = new Equipment() { Id = Guid.NewGuid(), Name = "Leather Hood",  Category = SlotCategory.Head, Price = 30, Strength = 10, Intelligence = -50, Agility =  50 };
        var e3 = new Equipment() { Id = Guid.NewGuid(), Name = "Mystic Crown",  Category = SlotCategory.Head, Price = 100, Strength = 5, Intelligence = 150,  Agility = 30 };
        
        // Chest category
        var e4 = new Equipment() { Id = Guid.NewGuid(), Name = "Chainmail Armor",  Category = SlotCategory.Chest, Price = 120, Strength = 80, Intelligence = 40,  Agility = -10 };
        var e5 = new Equipment() { Id = Guid.NewGuid(), Name = "Silk Robe",  Category = SlotCategory.Chest, Price = 80, Strength = 15, Intelligence = 100,  Agility = 70 };
        var e6 = new Equipment() { Id = Guid.NewGuid(), Name = "Battle Vest",  Category = SlotCategory.Chest, Price = 60, Strength = 60, Intelligence = -30, Agility =  90 };
        
        // Hand category
        var e7 = new Equipment() { Id = Guid.NewGuid(), Name = "Iron Gauntlets",  Category = SlotCategory.Hand, Price = 40, Strength = 50, Intelligence = 10,  Agility = 20 };
        var e8 = new Equipment() { Id = Guid.NewGuid(), Name = "Leather Gloves",  Category = SlotCategory.Hand, Price = 25, Strength = 15, Intelligence = 5,  Agility = 100 };
        var e9 = new Equipment() { Id = Guid.NewGuid(), Name = "Enchanted Gloves",  Category = SlotCategory.Hand, Price = 90, Strength = 8, Intelligence = 175,  Agility = 60 };
        
        // Feet category
        var e10 = new Equipment() { Id = Guid.NewGuid(), Name = "Steel Boots",  Category = SlotCategory.Feet, Price = 50, Strength = 40, Intelligence = -100, Agility =  30 };
        var e11 = new Equipment() { Id = Guid.NewGuid(), Name = "Ninja Sandals",  Category = SlotCategory.Feet, Price = 30, Strength = 10, Intelligence = 30,  Agility = 200 };
        var e12 = new Equipment() { Id = Guid.NewGuid(), Name = "Mage Slippers",  Category = SlotCategory.Feet, Price = 70, Strength = 5, Intelligence = 80,  Agility = 250 };
        
        // Ring category
        var e13 = new Equipment() { Id = Guid.NewGuid(), Name = "Ring of Strength", Category =  SlotCategory.Ring, Price = 200, Strength = 100, Intelligence = -20, Agility =  50 };
        var e14 = new Equipment() { Id = Guid.NewGuid(), Name = "Ring of Intelligence", Category =  SlotCategory.Ring, Price = 180, Strength = 5, Intelligence = 200,  Agility = -25 };
        var e15 = new Equipment() { Id = Guid.NewGuid(), Name = "Ring of Agility", Category =  SlotCategory.Ring, Price = 160, Strength = 10, Intelligence = -50, Agility =  300 };
        
        // Necklace category
        var e16 = new Equipment() { Id = Guid.NewGuid(), Name = "Amulet of Power", Category =  SlotCategory.Necklace, Price = 250, Strength = 90, Intelligence = 60,  Agility = 40 };
        var e17 = new Equipment() { Id = Guid.NewGuid(), Name = "Mystic Necklace",  Category = SlotCategory.Necklace, Price = 220, Strength = 20, Intelligence = 180,  Agility = 75 };
        var e18 = new Equipment() { Id = Guid.NewGuid(), Name = "Pendant of Speed", Category =  SlotCategory.Necklace, Price = 190, Strength = 5, Intelligence = 70,  Agility = 280 };
        
        modelBuilder.Entity<Equipment>().HasData(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18);
        
        // Inventory items
        var i1 = new InventoryItem() { Id = Guid.NewGuid(), NinjaId = n1.Id, EquipmentId = e1.Id };
        var i2 = new InventoryItem() { Id = Guid.NewGuid(), NinjaId = n1.Id, EquipmentId = e4.Id };
        var i3 = new InventoryItem() { Id = Guid.NewGuid(), NinjaId = n1.Id, EquipmentId = e7.Id };
        var i4 = new InventoryItem() { Id = Guid.NewGuid(), NinjaId = n2.Id, EquipmentId = e2.Id };
        var i5 = new InventoryItem() { Id = Guid.NewGuid(), NinjaId = n2.Id, EquipmentId = e5.Id };
        
        modelBuilder.Entity<InventoryItem>().HasData(i1, i2, i3, i4, i5);
    }
}