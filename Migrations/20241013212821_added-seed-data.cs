using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class addedseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("19e7e464-bd96-479e-8dd8-acad23579cba"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("2b1387cd-f03e-4893-9514-b01f9075010c"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("356f6b0c-b6df-4428-826a-7dbd50d2a2ae"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("3ce62de5-6ce1-4b44-8145-c04a289bee75"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("43594d95-8c39-4bf8-ac3e-2be05254f79f"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("43927808-7450-407c-aad3-41a05b394947"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("594f1f8c-64b9-40dc-8c21-ce98fbca452a"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("5977866e-3fd9-4ccf-b4bd-e48210c1cd5f"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("5ba8ee3b-cf0a-4ecd-91bd-2523745af040"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("724880a4-9551-4c3b-97e8-da7109083f88"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("9a9fda51-c846-4d3c-bf8d-d5f5db80384e"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("a67527cb-43cb-42f9-88cd-a40f181fe427"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("aebde5f1-0fe0-4a65-960d-7a96fe61cbd2"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("c4a0d124-aeb1-4341-af54-41bc32e84dad"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("ce7765c7-1169-4e6a-b696-981bd499fdc9"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("d6e8a6ef-075f-4413-8238-a8d9dca19dfb"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("d9dd2071-a018-496e-b0ff-3bbf6430c494"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("e3cf8928-5dcd-4a31-b77f-dce300c254f3"), 300, 4, -50, "Ring of Agility", 160, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("263b0800-1141-4632-b7e4-59127ed77c69"), 2000, "Shadowstrike Kenji" },
                    { new Guid("8b60cd81-d2b7-4e86-9720-0acbcb3f2e14"), 500, "Crimson Whisper" },
                    { new Guid("ce363fc7-2882-41f0-9e59-fb1c698f204f"), 2000, "Nightwind Taro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("19e7e464-bd96-479e-8dd8-acad23579cba"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2b1387cd-f03e-4893-9514-b01f9075010c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("356f6b0c-b6df-4428-826a-7dbd50d2a2ae"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3ce62de5-6ce1-4b44-8145-c04a289bee75"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("43594d95-8c39-4bf8-ac3e-2be05254f79f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("43927808-7450-407c-aad3-41a05b394947"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("594f1f8c-64b9-40dc-8c21-ce98fbca452a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5977866e-3fd9-4ccf-b4bd-e48210c1cd5f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5ba8ee3b-cf0a-4ecd-91bd-2523745af040"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("724880a4-9551-4c3b-97e8-da7109083f88"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("9a9fda51-c846-4d3c-bf8d-d5f5db80384e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a67527cb-43cb-42f9-88cd-a40f181fe427"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("aebde5f1-0fe0-4a65-960d-7a96fe61cbd2"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c4a0d124-aeb1-4341-af54-41bc32e84dad"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ce7765c7-1169-4e6a-b696-981bd499fdc9"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d6e8a6ef-075f-4413-8238-a8d9dca19dfb"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d9dd2071-a018-496e-b0ff-3bbf6430c494"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e3cf8928-5dcd-4a31-b77f-dce300c254f3"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("263b0800-1141-4632-b7e4-59127ed77c69"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("8b60cd81-d2b7-4e86-9720-0acbcb3f2e14"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("ce363fc7-2882-41f0-9e59-fb1c698f204f"));
        }
    }
}
