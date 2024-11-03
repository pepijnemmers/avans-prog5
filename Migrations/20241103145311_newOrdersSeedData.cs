using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class newOrdersSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("17320398-1ef4-4818-8599-9a9409b52158"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("2546f7f2-c3e6-48bd-98ef-d81ffc42152d"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("2898a80b-6936-4d9d-9c60-740102d1409c"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("3775f52e-4f7c-4059-a1a3-d761a4473225"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("49527477-41af-4de9-9df6-f80dff12acd9"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("4a444908-ed4e-4f40-bf57-9bb20b124bc2"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("57351fec-348c-4c75-b077-9b0d58d1dc55"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("5ec8e393-7f7c-4fbf-bdbd-2b9c577951b3"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("6245bae0-4693-4aa1-8d64-2b9d45270f8b"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("6df100d7-dfc4-4e9e-a18a-81d74619052c"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("776cf20c-d7e6-4b73-afbf-e6c410659d0b"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("8348abe7-b2d9-4ae5-9d68-a25ecbcb51c3"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("96abae21-086c-4ca0-85bb-cd8a76709946"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("a68cfc77-ad39-4568-9da2-f1cfcd4cc2c3"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("c922d2aa-78c3-43e5-9b43-52b74aaf7574"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("dea6f0b2-511c-4073-a146-9ade47b0fc5d"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("f27185f3-7d8a-4590-83d9-ab00f7d6c001"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("f79c44cc-656c-4f6f-94c7-b00b2759c9ec"), 60, 2, 175, "Enchanted Gloves", 90, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("7be98e5f-e8de-492e-837b-581bb493630f"), 2000, "Shadowstrike Kenji" },
                    { new Guid("835e4cf7-f75f-45ec-812e-620039ba0914"), 500, "Crimson Whisper" },
                    { new Guid("e50510ee-8f0d-437f-b0ae-af3f12f5560a"), 2000, "Nightwind Taro" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "EquipmentId", "NinjaId" },
                values: new object[,]
                {
                    { new Guid("0fdb0f79-7554-490b-9a0c-904fc58ed891"), new Guid("f27185f3-7d8a-4590-83d9-ab00f7d6c001"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f") },
                    { new Guid("a8c5c4e2-7024-46ae-9218-615b9ae203e6"), new Guid("5ec8e393-7f7c-4fbf-bdbd-2b9c577951b3"), new Guid("835e4cf7-f75f-45ec-812e-620039ba0914") },
                    { new Guid("b31e5d23-f338-4e68-bfd6-88f70ae6393f"), new Guid("8348abe7-b2d9-4ae5-9d68-a25ecbcb51c3"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f") },
                    { new Guid("c443b8b3-5ced-4b2c-b57f-bd916e6517a2"), new Guid("3775f52e-4f7c-4059-a1a3-d761a4473225"), new Guid("835e4cf7-f75f-45ec-812e-620039ba0914") },
                    { new Guid("e37432b0-b8dc-4064-85f0-b3746e82e0db"), new Guid("6245bae0-4693-4aa1-8d64-2b9d45270f8b"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "EquipmentId", "NinjaId", "Price" },
                values: new object[,]
                {
                    { new Guid("4e6bf2ca-df75-4cc0-8b88-8b5f70253b67"), new Guid("6245bae0-4693-4aa1-8d64-2b9d45270f8b"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f"), 40 },
                    { new Guid("6941bef1-1d89-4f7a-ac5b-5a81aa5f6f38"), new Guid("5ec8e393-7f7c-4fbf-bdbd-2b9c577951b3"), new Guid("835e4cf7-f75f-45ec-812e-620039ba0914"), 30 },
                    { new Guid("8f1bf675-ae4b-420a-a58c-4f884e00f69d"), new Guid("f27185f3-7d8a-4590-83d9-ab00f7d6c001"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f"), 120 },
                    { new Guid("a14a2979-7306-45ed-af75-7114612addcb"), new Guid("8348abe7-b2d9-4ae5-9d68-a25ecbcb51c3"), new Guid("7be98e5f-e8de-492e-837b-581bb493630f"), 50 },
                    { new Guid("ae29b7ce-4698-41f2-952c-d651358bf6cd"), new Guid("3775f52e-4f7c-4059-a1a3-d761a4473225"), new Guid("835e4cf7-f75f-45ec-812e-620039ba0914"), 80 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("17320398-1ef4-4818-8599-9a9409b52158"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2546f7f2-c3e6-48bd-98ef-d81ffc42152d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2898a80b-6936-4d9d-9c60-740102d1409c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("49527477-41af-4de9-9df6-f80dff12acd9"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("4a444908-ed4e-4f40-bf57-9bb20b124bc2"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("57351fec-348c-4c75-b077-9b0d58d1dc55"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6df100d7-dfc4-4e9e-a18a-81d74619052c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("776cf20c-d7e6-4b73-afbf-e6c410659d0b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("96abae21-086c-4ca0-85bb-cd8a76709946"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a68cfc77-ad39-4568-9da2-f1cfcd4cc2c3"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c922d2aa-78c3-43e5-9b43-52b74aaf7574"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("dea6f0b2-511c-4073-a146-9ade47b0fc5d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f79c44cc-656c-4f6f-94c7-b00b2759c9ec"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("0fdb0f79-7554-490b-9a0c-904fc58ed891"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("a8c5c4e2-7024-46ae-9218-615b9ae203e6"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("b31e5d23-f338-4e68-bfd6-88f70ae6393f"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("c443b8b3-5ced-4b2c-b57f-bd916e6517a2"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("e37432b0-b8dc-4064-85f0-b3746e82e0db"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("e50510ee-8f0d-437f-b0ae-af3f12f5560a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4e6bf2ca-df75-4cc0-8b88-8b5f70253b67"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6941bef1-1d89-4f7a-ac5b-5a81aa5f6f38"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8f1bf675-ae4b-420a-a58c-4f884e00f69d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a14a2979-7306-45ed-af75-7114612addcb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ae29b7ce-4698-41f2-952c-d651358bf6cd"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("3775f52e-4f7c-4059-a1a3-d761a4473225"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5ec8e393-7f7c-4fbf-bdbd-2b9c577951b3"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6245bae0-4693-4aa1-8d64-2b9d45270f8b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8348abe7-b2d9-4ae5-9d68-a25ecbcb51c3"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f27185f3-7d8a-4590-83d9-ab00f7d6c001"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("7be98e5f-e8de-492e-837b-581bb493630f"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("835e4cf7-f75f-45ec-812e-620039ba0914"));

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
    }
}
