using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedOrderWithFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("1398b36d-9036-4725-a8cc-3335423b4df4"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("1f2e6fa5-3cd4-4a7a-9f32-ea8fa7da0489"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("2fb77191-bb5b-441c-b85f-2fe468f17f40"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("4a447a9a-b435-412b-847a-0f4188cc8356"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("5c9849f7-3ea8-4acb-8903-c97f92d760b9"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("62b1e79f-e5fd-4153-941b-d0ca0711d995"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("81a04d0a-d976-4c51-8d76-bd6778298648"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("890c908d-345b-4604-97b7-f36b627dce1c"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("8a0cd42b-1373-4830-985e-635e6dba6e5c"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("97a74584-fc02-4609-bd17-079a1b3372f5"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("a4404053-2bca-4ff4-9f48-f0256a87f528"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("b8337871-8051-48a7-8dc0-6ac15d7fbfd1"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("c42f836e-8134-415d-b2e3-ef2335bc7480"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("c61006de-2573-415d-abac-c8a1778224e0"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("eaa1cc35-7910-4e21-830d-984e8cd31cf1"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("f0209de1-d8c9-4dc4-ac6f-e7f5e91a6510"), 280, 5, 70, "Pendant of Speed", 190, 5 },
                    { new Guid("f511fade-ee53-46f9-ae24-7b42f73f3786"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("fff219b3-95c6-4c1c-bcdd-f4c51786ae57"), -25, 4, 200, "Ring of Intelligence", 180, 5 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("5c12aa70-5ad1-4b64-be27-ee0d89fa7bcb"), 2000, "Nightwind Taro" },
                    { new Guid("7fe489cd-fbcd-41b1-8abf-3fc6661dfdd0"), 2000, "Shadowstrike Kenji" },
                    { new Guid("a74fccc6-8e66-43be-89a8-2f7f3f13a3aa"), 500, "Crimson Whisper" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "EquipmentId", "NinjaId", "SlotCategory" },
                values: new object[,]
                {
                    { new Guid("5032dd77-15ad-49d9-9487-931bb3cf13db"), new Guid("5c9849f7-3ea8-4acb-8903-c97f92d760b9"), new Guid("a74fccc6-8e66-43be-89a8-2f7f3f13a3aa"), 0 },
                    { new Guid("60496f77-be0b-44ad-94dd-dd43c2632534"), new Guid("97a74584-fc02-4609-bd17-079a1b3372f5"), new Guid("7fe489cd-fbcd-41b1-8abf-3fc6661dfdd0"), 2 },
                    { new Guid("6a80dea8-5cde-4ae0-ac75-af5e7ce742e2"), new Guid("890c908d-345b-4604-97b7-f36b627dce1c"), new Guid("7fe489cd-fbcd-41b1-8abf-3fc6661dfdd0"), 1 },
                    { new Guid("87990ca7-9b6c-4dba-b62b-4493c1410ea3"), new Guid("b8337871-8051-48a7-8dc0-6ac15d7fbfd1"), new Guid("7fe489cd-fbcd-41b1-8abf-3fc6661dfdd0"), 0 },
                    { new Guid("ea0c59a0-78ce-41bf-84ab-02f0fbfdbdb4"), new Guid("c61006de-2573-415d-abac-c8a1778224e0"), new Guid("a74fccc6-8e66-43be-89a8-2f7f3f13a3aa"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1398b36d-9036-4725-a8cc-3335423b4df4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("1f2e6fa5-3cd4-4a7a-9f32-ea8fa7da0489"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("2fb77191-bb5b-441c-b85f-2fe468f17f40"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("4a447a9a-b435-412b-847a-0f4188cc8356"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("62b1e79f-e5fd-4153-941b-d0ca0711d995"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("81a04d0a-d976-4c51-8d76-bd6778298648"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8a0cd42b-1373-4830-985e-635e6dba6e5c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("a4404053-2bca-4ff4-9f48-f0256a87f528"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c42f836e-8134-415d-b2e3-ef2335bc7480"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("eaa1cc35-7910-4e21-830d-984e8cd31cf1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f0209de1-d8c9-4dc4-ac6f-e7f5e91a6510"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f511fade-ee53-46f9-ae24-7b42f73f3786"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("fff219b3-95c6-4c1c-bcdd-f4c51786ae57"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("5032dd77-15ad-49d9-9487-931bb3cf13db"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("60496f77-be0b-44ad-94dd-dd43c2632534"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("6a80dea8-5cde-4ae0-ac75-af5e7ce742e2"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("87990ca7-9b6c-4dba-b62b-4493c1410ea3"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("ea0c59a0-78ce-41bf-84ab-02f0fbfdbdb4"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("5c12aa70-5ad1-4b64-be27-ee0d89fa7bcb"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5c9849f7-3ea8-4acb-8903-c97f92d760b9"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("890c908d-345b-4604-97b7-f36b627dce1c"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("97a74584-fc02-4609-bd17-079a1b3372f5"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("b8337871-8051-48a7-8dc0-6ac15d7fbfd1"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c61006de-2573-415d-abac-c8a1778224e0"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("7fe489cd-fbcd-41b1-8abf-3fc6661dfdd0"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("a74fccc6-8e66-43be-89a8-2f7f3f13a3aa"));

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
        }
    }
}
