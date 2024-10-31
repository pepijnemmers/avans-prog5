using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("16d3df9f-8c95-493b-83bf-30f8814cd292"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("1839c1d1-ba91-470c-984c-b0be7c2e6749"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("1c318831-e602-4736-9501-3b7955a61ac4"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("3a3217e4-7fc5-44b9-ab78-7ba1d6f30059"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("40836e54-bcdb-4992-a1f4-f680838f7d97"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("56964eec-c901-4ff5-a064-5d2d5202127c"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("597175c5-f705-466e-90e7-59c6a7a552fe"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("59f9994e-1693-4362-a937-6990de3d95fd"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("5bef76c8-3ca8-4b12-921c-3cde5fd5b25e"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("76d13a7a-0bfd-4830-8633-e905c42636cb"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("86be4da2-2736-40d0-8822-712fe43e4150"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("87d92e5f-5fdd-4584-a9ec-2497bfd2741f"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("8fcbb75e-15a0-47c3-a41e-f32ab5ea2772"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("af33fa1a-5213-498d-b112-8b5326332480"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("bd568a85-9bc3-4817-af3a-3f2333a9f884"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("c1629c2f-1f52-4d2d-a6ca-73b32caa516f"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("ce6b3185-a903-4af0-b302-8b596aaa5e2f"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("cf393a15-1a25-4685-a9ac-9834275b7425"), 50, 4, -20, "Ring of Strength", 200, 100 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("348d718c-e7e0-42c9-8daa-66d0f67ee7b8"), 2000, "Nightwind Taro" },
                    { new Guid("9561f95c-7591-4b7d-af9c-247514c290ed"), 500, "Crimson Whisper" },
                    { new Guid("a3dc9f57-3d72-4a66-adb5-84d26343742e"), 2000, "Shadowstrike Kenji" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("16d3df9f-8c95-493b-83bf-30f8814cd292"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1839c1d1-ba91-470c-984c-b0be7c2e6749"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1c318831-e602-4736-9501-3b7955a61ac4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3a3217e4-7fc5-44b9-ab78-7ba1d6f30059"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("40836e54-bcdb-4992-a1f4-f680838f7d97"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("56964eec-c901-4ff5-a064-5d2d5202127c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("597175c5-f705-466e-90e7-59c6a7a552fe"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("59f9994e-1693-4362-a937-6990de3d95fd"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5bef76c8-3ca8-4b12-921c-3cde5fd5b25e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("76d13a7a-0bfd-4830-8633-e905c42636cb"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("86be4da2-2736-40d0-8822-712fe43e4150"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("87d92e5f-5fdd-4584-a9ec-2497bfd2741f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8fcbb75e-15a0-47c3-a41e-f32ab5ea2772"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("af33fa1a-5213-498d-b112-8b5326332480"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bd568a85-9bc3-4817-af3a-3f2333a9f884"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c1629c2f-1f52-4d2d-a6ca-73b32caa516f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ce6b3185-a903-4af0-b302-8b596aaa5e2f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("cf393a15-1a25-4685-a9ac-9834275b7425"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("348d718c-e7e0-42c9-8daa-66d0f67ee7b8"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("9561f95c-7591-4b7d-af9c-247514c290ed"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("a3dc9f57-3d72-4a66-adb5-84d26343742e"));

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
    }
}
