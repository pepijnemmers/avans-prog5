using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class InventoryMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0e839355-bf6f-4d99-ae97-a245dba3ae10"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("1e807e09-ed39-4b81-a3ba-6f872398cabe"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("3ecc1a5c-b12f-41f2-b274-c4f4d6cbd7c1"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("5e7bf1cb-d376-49f7-8e1e-72be0e8d368a"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("5e7cbe5f-ae4a-42bb-b5f7-739d975f35d1"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("687075c0-a022-4d9d-9141-1158f6c9e2f4"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("69097123-b703-4c16-9937-7eba66690b62"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("6d950c2d-1198-4579-966d-fed523b3c4d7"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("779f12b9-4140-4df5-a204-19c8fc1bde18"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("7f8a5115-66f5-4916-a29d-d57dff22302f"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("8e842fbd-e902-40c5-a3c5-0b0629eb5e8f"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("8e8c1598-0b3f-4f18-a093-1c0190411573"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("8f2929d4-04d5-40f8-967d-eabeba53edad"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("bbe0c2c7-98bc-41c0-8062-0b03e5cae1bd"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("c1000c3b-ab87-4e38-a06b-d63b1c0f53d8"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("cb6adae6-fbc0-4c41-99d7-7bfe17eca1df"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("e69277c6-9d24-47a3-b299-bf16b5fa77ed"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("e6f932b6-20df-4738-8637-10dc3f167d4c"), 300, 4, -50, "Ring of Agility", 160, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("061d78d8-cb2e-4075-b404-b48157a2d707"), 2000, "Nightwind Taro" },
                    { new Guid("2b0820e6-6522-4668-b1ea-dcb95cc6a772"), 2000, "Shadowstrike Kenji" },
                    { new Guid("bcf24c14-c1ee-43d9-beb1-8456b687b359"), 500, "Crimson Whisper" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "EquipmentId", "NinjaId" },
                values: new object[,]
                {
                    { new Guid("032a5063-a31a-4436-ae54-52ef4e21285e"), new Guid("7f8a5115-66f5-4916-a29d-d57dff22302f"), new Guid("2b0820e6-6522-4668-b1ea-dcb95cc6a772") },
                    { new Guid("684d033e-15de-43a9-b0ba-776a934370d1"), new Guid("3ecc1a5c-b12f-41f2-b274-c4f4d6cbd7c1"), new Guid("2b0820e6-6522-4668-b1ea-dcb95cc6a772") },
                    { new Guid("8f1e6eac-ce01-4ca6-b82e-ec3a851aaea1"), new Guid("0e839355-bf6f-4d99-ae97-a245dba3ae10"), new Guid("bcf24c14-c1ee-43d9-beb1-8456b687b359") },
                    { new Guid("9531dbb6-a084-4527-a17e-f4cc61aafc78"), new Guid("6d950c2d-1198-4579-966d-fed523b3c4d7"), new Guid("bcf24c14-c1ee-43d9-beb1-8456b687b359") },
                    { new Guid("9deb1790-0db3-4920-92af-b3171c2beac3"), new Guid("bbe0c2c7-98bc-41c0-8062-0b03e5cae1bd"), new Guid("2b0820e6-6522-4668-b1ea-dcb95cc6a772") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1e807e09-ed39-4b81-a3ba-6f872398cabe"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5e7bf1cb-d376-49f7-8e1e-72be0e8d368a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5e7cbe5f-ae4a-42bb-b5f7-739d975f35d1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("687075c0-a022-4d9d-9141-1158f6c9e2f4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("69097123-b703-4c16-9937-7eba66690b62"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("779f12b9-4140-4df5-a204-19c8fc1bde18"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8e842fbd-e902-40c5-a3c5-0b0629eb5e8f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8e8c1598-0b3f-4f18-a093-1c0190411573"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8f2929d4-04d5-40f8-967d-eabeba53edad"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c1000c3b-ab87-4e38-a06b-d63b1c0f53d8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("cb6adae6-fbc0-4c41-99d7-7bfe17eca1df"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e69277c6-9d24-47a3-b299-bf16b5fa77ed"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e6f932b6-20df-4738-8637-10dc3f167d4c"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("032a5063-a31a-4436-ae54-52ef4e21285e"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("684d033e-15de-43a9-b0ba-776a934370d1"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("8f1e6eac-ce01-4ca6-b82e-ec3a851aaea1"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("9531dbb6-a084-4527-a17e-f4cc61aafc78"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("9deb1790-0db3-4920-92af-b3171c2beac3"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("061d78d8-cb2e-4075-b404-b48157a2d707"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("0e839355-bf6f-4d99-ae97-a245dba3ae10"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3ecc1a5c-b12f-41f2-b274-c4f4d6cbd7c1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6d950c2d-1198-4579-966d-fed523b3c4d7"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("7f8a5115-66f5-4916-a29d-d57dff22302f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bbe0c2c7-98bc-41c0-8062-0b03e5cae1bd"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("2b0820e6-6522-4668-b1ea-dcb95cc6a772"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("bcf24c14-c1ee-43d9-beb1-8456b687b359"));

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
    }
}
