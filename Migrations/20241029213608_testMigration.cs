using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class testMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("0b2a4ff7-910c-4e76-993b-8f5f7722017b"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("1027e596-0cd3-44a4-bc14-2d7860dbdf9b"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("34c8efe3-7a28-4e3f-a144-350b7c38ec94"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("44f68133-ba72-4e89-b08c-80cc5858c97e"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("54a65338-963a-4833-b05f-d012d4b46a5e"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("64778bca-c05d-475e-8e68-c5b4dd3a4d57"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("6841c3a3-ace0-4d9b-861d-ef7e1de7f0a0"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("70d914f5-6b2d-47a8-a478-23d0e9d835e8"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("81c5925f-9260-4e60-b9bf-c12edae930c2"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("a24cfc52-8c55-45fd-bd2b-02aa50a66142"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("a5737cf9-4fb0-4f3c-a4f8-0ad7dc50baaf"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("a73cebae-894f-4076-b218-958aee7ba69c"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("a9a732f7-1bb6-4197-ba55-aba665344b38"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("ba3f7aa2-08a3-4e54-a197-97b85914f2fb"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("bcf1de67-ff77-41d0-8944-33832c23caed"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("c73555d7-7c8a-4b3d-8196-9528f5f93995"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("c8547d1e-ba7d-4c98-b51f-0ed6ba12cb98"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("ef482938-31e1-429a-b811-61aba3e11797"), 200, 3, 30, "Ninja Sandals", 30, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("073f438f-737e-439c-9f5d-b7dd6b2f5d01"), 2000, "Shadowstrike Kenji" },
                    { new Guid("143e91e3-3264-4a08-90d1-95498744e8b8"), 500, "Crimson Whisper" },
                    { new Guid("9d139100-810d-41be-83b3-86a60bd66f05"), 2000, "Nightwind Taro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("0b2a4ff7-910c-4e76-993b-8f5f7722017b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1027e596-0cd3-44a4-bc14-2d7860dbdf9b"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("34c8efe3-7a28-4e3f-a144-350b7c38ec94"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("44f68133-ba72-4e89-b08c-80cc5858c97e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("54a65338-963a-4833-b05f-d012d4b46a5e"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("64778bca-c05d-475e-8e68-c5b4dd3a4d57"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6841c3a3-ace0-4d9b-861d-ef7e1de7f0a0"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("70d914f5-6b2d-47a8-a478-23d0e9d835e8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("81c5925f-9260-4e60-b9bf-c12edae930c2"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a24cfc52-8c55-45fd-bd2b-02aa50a66142"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a5737cf9-4fb0-4f3c-a4f8-0ad7dc50baaf"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a73cebae-894f-4076-b218-958aee7ba69c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a9a732f7-1bb6-4197-ba55-aba665344b38"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ba3f7aa2-08a3-4e54-a197-97b85914f2fb"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bcf1de67-ff77-41d0-8944-33832c23caed"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c73555d7-7c8a-4b3d-8196-9528f5f93995"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c8547d1e-ba7d-4c98-b51f-0ed6ba12cb98"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ef482938-31e1-429a-b811-61aba3e11797"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("073f438f-737e-439c-9f5d-b7dd6b2f5d01"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("143e91e3-3264-4a08-90d1-95498744e8b8"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("9d139100-810d-41be-83b3-86a60bd66f05"));

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
    }
}
