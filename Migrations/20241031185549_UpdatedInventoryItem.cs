using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInventoryItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItem_Equipments_EquipmentId",
                table: "InventoryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItem_Ninjas_NinjaId",
                table: "InventoryItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItem",
                table: "InventoryItem");

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

            migrationBuilder.RenameTable(
                name: "InventoryItem",
                newName: "InventoryItems");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItem_NinjaId",
                table: "InventoryItems",
                newName: "IX_InventoryItems_NinjaId");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItem_EquipmentId",
                table: "InventoryItems",
                newName: "IX_InventoryItems_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("181d6be2-e017-48d0-a328-6998051e7c59"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("1c425fd4-c50c-48c4-8511-066705141c61"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("2d60fbe8-6eae-4a34-9df9-b31990c4a873"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("42eff9c7-8694-4cdb-9e57-7f82301e57a5"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("46f0b7a1-90b0-4fe8-974d-6921a505de68"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("5e196fcc-af8d-45e6-9a94-b8c5e8131387"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("6e00cd5c-e74b-4860-aaae-5dd59f368be8"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("72c9d37d-cf5c-44c1-b394-04a8dd410440"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("73d4cb7b-2729-4c09-91ab-d7e2b7818451"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("8d54ce4b-569a-4903-bed9-b9f5711733c4"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("b4e9d474-196f-47f5-a83c-d7218288c929"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("d29ef4aa-7faa-4d6f-b983-7b10e85244ce"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("d3630843-fd37-4900-8ce2-0401dae8639d"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("d7ea24b5-86c3-48d3-8b44-41f112f898b6"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("e1a9e9fe-f314-493a-a45d-6b855449a910"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("f2896bdf-4763-49bf-9460-9016ee1ddcc5"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("fd17aaba-6cf0-48a6-a3ce-3167892267ee"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("fdf5a04d-fcf3-499b-827a-d5008203c047"), 30, 0, 150, "Mystic Crown", 100, 5 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("2f42f382-2d81-430d-bc6b-ccf91586887c"), 2000, "Shadowstrike Kenji" },
                    { new Guid("39f7717a-f353-4bdb-af0f-46b217a0da8c"), 2000, "Nightwind Taro" },
                    { new Guid("64426b12-e2a6-4d99-9543-f1254682f5e3"), 500, "Crimson Whisper" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "EquipmentId", "NinjaId", "SlotCategory" },
                values: new object[,]
                {
                    { new Guid("0bd2c676-644a-4f3d-86ec-d2527f6f1632"), new Guid("2d60fbe8-6eae-4a34-9df9-b31990c4a873"), new Guid("2f42f382-2d81-430d-bc6b-ccf91586887c"), 2 },
                    { new Guid("413c0b24-684b-4d64-a908-c387b110c03b"), new Guid("e1a9e9fe-f314-493a-a45d-6b855449a910"), new Guid("64426b12-e2a6-4d99-9543-f1254682f5e3"), 1 },
                    { new Guid("427f75ed-1f59-4a67-aed7-1440f62e35a9"), new Guid("46f0b7a1-90b0-4fe8-974d-6921a505de68"), new Guid("64426b12-e2a6-4d99-9543-f1254682f5e3"), 0 },
                    { new Guid("56c43a75-72ed-4378-9607-10ba888751f3"), new Guid("d29ef4aa-7faa-4d6f-b983-7b10e85244ce"), new Guid("2f42f382-2d81-430d-bc6b-ccf91586887c"), 0 },
                    { new Guid("b2c579d0-8174-489d-8f71-c5b169e528d7"), new Guid("b4e9d474-196f-47f5-a83c-d7218288c929"), new Guid("2f42f382-2d81-430d-bc6b-ccf91586887c"), 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Equipments_EquipmentId",
                table: "InventoryItems",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Ninjas_NinjaId",
                table: "InventoryItems",
                column: "NinjaId",
                principalTable: "Ninjas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Equipments_EquipmentId",
                table: "InventoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Ninjas_NinjaId",
                table: "InventoryItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("181d6be2-e017-48d0-a328-6998051e7c59"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1c425fd4-c50c-48c4-8511-066705141c61"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("42eff9c7-8694-4cdb-9e57-7f82301e57a5"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5e196fcc-af8d-45e6-9a94-b8c5e8131387"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("6e00cd5c-e74b-4860-aaae-5dd59f368be8"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("72c9d37d-cf5c-44c1-b394-04a8dd410440"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("73d4cb7b-2729-4c09-91ab-d7e2b7818451"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8d54ce4b-569a-4903-bed9-b9f5711733c4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d3630843-fd37-4900-8ce2-0401dae8639d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d7ea24b5-86c3-48d3-8b44-41f112f898b6"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f2896bdf-4763-49bf-9460-9016ee1ddcc5"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("fd17aaba-6cf0-48a6-a3ce-3167892267ee"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("fdf5a04d-fcf3-499b-827a-d5008203c047"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("0bd2c676-644a-4f3d-86ec-d2527f6f1632"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("413c0b24-684b-4d64-a908-c387b110c03b"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("427f75ed-1f59-4a67-aed7-1440f62e35a9"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("56c43a75-72ed-4378-9607-10ba888751f3"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("b2c579d0-8174-489d-8f71-c5b169e528d7"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("39f7717a-f353-4bdb-af0f-46b217a0da8c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2d60fbe8-6eae-4a34-9df9-b31990c4a873"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("46f0b7a1-90b0-4fe8-974d-6921a505de68"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("b4e9d474-196f-47f5-a83c-d7218288c929"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("d29ef4aa-7faa-4d6f-b983-7b10e85244ce"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("e1a9e9fe-f314-493a-a45d-6b855449a910"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("2f42f382-2d81-430d-bc6b-ccf91586887c"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("64426b12-e2a6-4d99-9543-f1254682f5e3"));

            migrationBuilder.RenameTable(
                name: "InventoryItems",
                newName: "InventoryItem");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItems_NinjaId",
                table: "InventoryItem",
                newName: "IX_InventoryItem_NinjaId");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryItems_EquipmentId",
                table: "InventoryItem",
                newName: "IX_InventoryItem_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItem",
                table: "InventoryItem",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItem_Equipments_EquipmentId",
                table: "InventoryItem",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItem_Ninjas_NinjaId",
                table: "InventoryItem",
                column: "NinjaId",
                principalTable: "Ninjas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
