using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class equipmentSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("43ecf84c-e0f3-4e10-bc37-58600dbabc5d"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("a0907f17-9be6-4ce5-ae4e-705f1fc1e88d"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("f2ea3608-1fb2-4c1d-ab92-9202ac544ec6"));

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("14a55dfa-9964-4105-8537-350a14268017"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("198427ac-1b6a-477e-9fb0-eff4dbd29162"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("41bb2d56-c87c-4860-af6b-107266e32c3d"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("51bd3494-b627-4646-a172-a7f36768d7e6"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("69c7c108-183f-4561-9799-1568703779f8"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("72e3516d-1aa5-4102-b5e1-9f06a54a1153"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("76999a9b-ccd0-42c8-bec4-3ba4cebcfc76"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("81625fee-84dc-4944-8895-05ca8b3ebd2e"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("83bce5e5-aa3a-41b1-8c3f-2997f512ebf4"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("ab666ee8-43d6-48f4-a502-fd23a9e4409e"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("bbc132d5-ac70-4828-911e-da68393e544c"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("bde03647-373d-4f0e-b799-b2e37c67845d"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("be0b4d6c-1602-4460-9b36-d58939ffa759"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("d321cbf1-4680-441f-b594-8f2891b71eab"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("d807b48f-0907-48cd-bec1-5d95e4636eb1"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("dda27126-8d28-44ef-9646-30388e7a4dad"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("e00f5976-f80b-4fdd-b534-7a11d4135880"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("f6fe57bd-9442-424b-b16c-3b075c971f19"), 280, 5, 70, "Pendant of Speed", 190, 5 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("32c32db7-22b0-4d81-a128-94f5c8c22b82"), 2000, "Shadowstrike Kenji" },
                    { new Guid("5de79c1f-f4c0-4377-b9d6-3d781102ba35"), 2000, "Nightwind Taro" },
                    { new Guid("e5dd3615-24b3-498c-9a05-6c0aab0fd813"), 500, "Crimson Whisper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("14a55dfa-9964-4105-8537-350a14268017"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("198427ac-1b6a-477e-9fb0-eff4dbd29162"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("41bb2d56-c87c-4860-af6b-107266e32c3d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("51bd3494-b627-4646-a172-a7f36768d7e6"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("69c7c108-183f-4561-9799-1568703779f8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("72e3516d-1aa5-4102-b5e1-9f06a54a1153"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("76999a9b-ccd0-42c8-bec4-3ba4cebcfc76"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("81625fee-84dc-4944-8895-05ca8b3ebd2e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("83bce5e5-aa3a-41b1-8c3f-2997f512ebf4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ab666ee8-43d6-48f4-a502-fd23a9e4409e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bbc132d5-ac70-4828-911e-da68393e544c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bde03647-373d-4f0e-b799-b2e37c67845d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("be0b4d6c-1602-4460-9b36-d58939ffa759"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d321cbf1-4680-441f-b594-8f2891b71eab"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d807b48f-0907-48cd-bec1-5d95e4636eb1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("dda27126-8d28-44ef-9646-30388e7a4dad"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e00f5976-f80b-4fdd-b534-7a11d4135880"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f6fe57bd-9442-424b-b16c-3b075c971f19"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("32c32db7-22b0-4d81-a128-94f5c8c22b82"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("5de79c1f-f4c0-4377-b9d6-3d781102ba35"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("e5dd3615-24b3-498c-9a05-6c0aab0fd813"));

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("43ecf84c-e0f3-4e10-bc37-58600dbabc5d"), 500, "Crimson Whisper" },
                    { new Guid("a0907f17-9be6-4ce5-ae4e-705f1fc1e88d"), 2000, "Shadowstrike Kenji" },
                    { new Guid("f2ea3608-1fb2-4c1d-ab92-9202ac544ec6"), 2000, "Nightwind Taro" }
                });
        }
    }
}
