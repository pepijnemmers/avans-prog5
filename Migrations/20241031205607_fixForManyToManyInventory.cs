using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class fixForManyToManyInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("241e3387-35f6-489f-b2c0-0ece0a335a2a"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("31f562ee-b6fe-466d-8678-3716761a7532"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("3a4d0f45-48d6-4abf-ac3a-644073a37e7a"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("3b5c8b6f-e3f4-4d55-bc1a-690b26e06d98"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("4daa48b3-b218-4d90-864c-7995201be170"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("5fddc917-0edc-402d-8dad-c367f36bf969"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("692c85f9-2f3d-402c-80ff-7e7d4a883b46"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("6c4371e8-aef1-4f35-a284-e07266b27dc8"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("7e64ba8f-60fb-4f45-b336-35d492eadf37"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("81246263-02ba-42fa-946d-19e5782572bc"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("8b35217f-940e-498f-8826-f1603ccab4f1"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("967bf2a8-85fe-4d3f-aeb5-9abaae66743b"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("c525d662-3828-411a-8d07-cf84d01b8763"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("ca704078-b6f2-44e9-bf86-8d1c6d3dee27"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("d6605cc5-b5a1-408d-b2d9-4c6d9323ec45"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("e1a2c576-e89e-452f-a863-c295aea230f5"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("e28b4170-e371-4a6d-919d-379bdbbb3728"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("f8c60582-5428-4500-b26e-1916aa90d4ac"), -10, 1, 40, "Chainmail Armor", 120, 80 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("08ef212c-ef31-4901-aabd-4660cb5b52b4"), 2000, "Nightwind Taro" },
                    { new Guid("a6731d1b-88f0-4e74-b851-3fd1138f0bf6"), 2000, "Shadowstrike Kenji" },
                    { new Guid("ff2ab46c-af86-4e9f-ac71-05a1592839c9"), 500, "Crimson Whisper" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "EquipmentId", "NinjaId" },
                values: new object[] { new Guid("af1c5735-da07-43cc-9f00-48704c40ab01"), new Guid("967bf2a8-85fe-4d3f-aeb5-9abaae66743b"), new Guid("a6731d1b-88f0-4e74-b851-3fd1138f0bf6") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("241e3387-35f6-489f-b2c0-0ece0a335a2a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("31f562ee-b6fe-466d-8678-3716761a7532"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3a4d0f45-48d6-4abf-ac3a-644073a37e7a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3b5c8b6f-e3f4-4d55-bc1a-690b26e06d98"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("4daa48b3-b218-4d90-864c-7995201be170"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5fddc917-0edc-402d-8dad-c367f36bf969"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("692c85f9-2f3d-402c-80ff-7e7d4a883b46"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6c4371e8-aef1-4f35-a284-e07266b27dc8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("7e64ba8f-60fb-4f45-b336-35d492eadf37"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("81246263-02ba-42fa-946d-19e5782572bc"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8b35217f-940e-498f-8826-f1603ccab4f1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c525d662-3828-411a-8d07-cf84d01b8763"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ca704078-b6f2-44e9-bf86-8d1c6d3dee27"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d6605cc5-b5a1-408d-b2d9-4c6d9323ec45"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e1a2c576-e89e-452f-a863-c295aea230f5"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e28b4170-e371-4a6d-919d-379bdbbb3728"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f8c60582-5428-4500-b26e-1916aa90d4ac"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("af1c5735-da07-43cc-9f00-48704c40ab01"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("08ef212c-ef31-4901-aabd-4660cb5b52b4"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("ff2ab46c-af86-4e9f-ac71-05a1592839c9"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("967bf2a8-85fe-4d3f-aeb5-9abaae66743b"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("a6731d1b-88f0-4e74-b851-3fd1138f0bf6"));

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
    }
}
