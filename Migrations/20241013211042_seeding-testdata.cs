using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class seedingtestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("0ab3f660-2816-42b7-99f6-48c526d1ff27"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("0bb29a5c-ae9c-4e19-8dbc-ef22f3572e5f"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("15bc0c2b-91f5-4f87-8b59-4c2a571b016a"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("290de8d4-7738-41f2-b2af-4d4593aadb87"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("2b1be77b-1193-4843-949b-70592db629e5"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("39bcab68-e85c-43f6-ab1c-f2d30444b27c"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("4ac5bf68-142c-4c82-a61e-29a59379867e"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("5d0b7961-a319-42e6-8607-bd78ca823a21"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("60a0b128-f465-4cc3-aa57-3bd938c83b6b"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("689375b0-bc66-414b-924c-2b40158fcc56"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("72c82a30-322f-430c-85d1-01dbc0bfe0a4"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("7b20bb5a-0184-4f50-8d7d-d0773adc65b8"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("8055ae32-7a34-439b-af7c-7693fc52038b"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("aa1cab19-3d39-4781-91ae-d876d5193a0e"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("b1f22a23-686d-4bbb-84e1-8e2e4af178d7"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("eff0ff16-6e44-43a5-b46b-682f5e01741d"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("fb9abee2-6a6a-4eee-989c-c60872c92b9d"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("fdbcd5d1-9553-429f-9029-2ce90eee3328"), 60, 2, 175, "Enchanted Gloves", 90, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("68cfa750-f57c-4fa4-b840-caf38b67f979"), 2000, "Shadowstrike Kenji" },
                    { new Guid("82d46009-c3f5-4275-b83a-cf7f3153dc3c"), 2000, "Nightwind Taro" },
                    { new Guid("d57c3c6b-0697-4b93-97d7-8d241df5b8d3"), 500, "Crimson Whisper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("0ab3f660-2816-42b7-99f6-48c526d1ff27"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("0bb29a5c-ae9c-4e19-8dbc-ef22f3572e5f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("15bc0c2b-91f5-4f87-8b59-4c2a571b016a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("290de8d4-7738-41f2-b2af-4d4593aadb87"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2b1be77b-1193-4843-949b-70592db629e5"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("39bcab68-e85c-43f6-ab1c-f2d30444b27c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("4ac5bf68-142c-4c82-a61e-29a59379867e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5d0b7961-a319-42e6-8607-bd78ca823a21"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("60a0b128-f465-4cc3-aa57-3bd938c83b6b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("689375b0-bc66-414b-924c-2b40158fcc56"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("72c82a30-322f-430c-85d1-01dbc0bfe0a4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("7b20bb5a-0184-4f50-8d7d-d0773adc65b8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8055ae32-7a34-439b-af7c-7693fc52038b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("aa1cab19-3d39-4781-91ae-d876d5193a0e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("b1f22a23-686d-4bbb-84e1-8e2e4af178d7"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("eff0ff16-6e44-43a5-b46b-682f5e01741d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("fb9abee2-6a6a-4eee-989c-c60872c92b9d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("fdbcd5d1-9553-429f-9029-2ce90eee3328"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("68cfa750-f57c-4fa4-b840-caf38b67f979"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("82d46009-c3f5-4275-b83a-cf7f3153dc3c"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("d57c3c6b-0697-4b93-97d7-8d241df5b8d3"));
        }
    }
}
