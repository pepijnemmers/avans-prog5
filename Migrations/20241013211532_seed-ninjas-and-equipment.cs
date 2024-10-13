using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class seedninjasandequipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { new Guid("294c2784-de64-45c2-ab94-157d6963a2d3"), 300, 4, -50, "Ring of Agility", 160, 10 },
                    { new Guid("32d87f35-58b8-4de0-beba-6154ab59529a"), -10, 1, 40, "Chainmail Armor", 120, 80 },
                    { new Guid("4f5b5e32-46e0-4961-9c3a-fc7669d998bc"), -25, 4, 200, "Ring of Intelligence", 180, 5 },
                    { new Guid("532f00f2-2388-4446-880b-1d64ba067995"), 100, 2, 5, "Leather Gloves", 25, 15 },
                    { new Guid("560daca4-cb75-4e44-8112-d1db5d6d501d"), 60, 2, 175, "Enchanted Gloves", 90, 8 },
                    { new Guid("589eacbb-9197-4def-b0d2-58e511878d97"), 30, 0, 150, "Mystic Crown", 100, 5 },
                    { new Guid("5b010d11-b8b1-4d05-9fcf-329ceb0f8e67"), 50, 4, -20, "Ring of Strength", 200, 100 },
                    { new Guid("68420241-7871-412a-b490-7f065ceed8d4"), 20, 2, 10, "Iron Gauntlets", 40, 50 },
                    { new Guid("7f54efe2-4208-4bcc-82e7-537aab5e5878"), 75, 5, 180, "Mystic Necklace", 220, 20 },
                    { new Guid("8b9838d2-66a1-4323-99ff-9527b2461430"), 10, 0, 20, "Steel Helmet", 50, 30 },
                    { new Guid("9a8254fd-aeec-415c-b3a2-cc0bade31649"), 70, 1, 100, "Silk Robe", 80, 15 },
                    { new Guid("9d1ddb4d-5b34-4e6b-b859-4c2671048906"), 30, 3, -100, "Steel Boots", 50, 40 },
                    { new Guid("ab3edc55-c09b-4bef-af4c-3c5a7224be9f"), 90, 1, -30, "Battle Vest", 60, 60 },
                    { new Guid("b1ff3b66-bf82-4061-822a-a92186e72b63"), 40, 5, 60, "Amulet of Power", 250, 90 },
                    { new Guid("b66905e2-bea0-4b84-ae8b-85f58d0c93ac"), 50, 0, -50, "Leather Hood", 30, 10 },
                    { new Guid("bff935bd-e0a6-4ba8-9e21-1e7793ddfb31"), 250, 3, 80, "Mage Slippers", 70, 5 },
                    { new Guid("c458dd35-be5b-47a1-9683-29adc301b67f"), 200, 3, 30, "Ninja Sandals", 30, 10 },
                    { new Guid("f41a43db-e374-4c1e-89c4-f78416ef03b4"), 280, 5, 70, "Pendant of Speed", 190, 5 }
                });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name" },
                values: new object[,]
                {
                    { new Guid("3090b339-c693-4c49-b7e1-6509456c987a"), 500, "Crimson Whisper" },
                    { new Guid("b06a4db7-6db3-454c-a593-7d140dad4d90"), 2000, "Shadowstrike Kenji" },
                    { new Guid("fea7194f-a9f9-43fa-b811-1c60de5f451b"), 2000, "Nightwind Taro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("294c2784-de64-45c2-ab94-157d6963a2d3"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("32d87f35-58b8-4de0-beba-6154ab59529a"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("4f5b5e32-46e0-4961-9c3a-fc7669d998bc"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("532f00f2-2388-4446-880b-1d64ba067995"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("560daca4-cb75-4e44-8112-d1db5d6d501d"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("589eacbb-9197-4def-b0d2-58e511878d97"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("5b010d11-b8b1-4d05-9fcf-329ceb0f8e67"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("68420241-7871-412a-b490-7f065ceed8d4"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("7f54efe2-4208-4bcc-82e7-537aab5e5878"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("8b9838d2-66a1-4323-99ff-9527b2461430"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("9a8254fd-aeec-415c-b3a2-cc0bade31649"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("9d1ddb4d-5b34-4e6b-b859-4c2671048906"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("ab3edc55-c09b-4bef-af4c-3c5a7224be9f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("b1ff3b66-bf82-4061-822a-a92186e72b63"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("b66905e2-bea0-4b84-ae8b-85f58d0c93ac"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("bff935bd-e0a6-4ba8-9e21-1e7793ddfb31"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("c458dd35-be5b-47a1-9683-29adc301b67f"));

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: new Guid("f41a43db-e374-4c1e-89c4-f78416ef03b4"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("3090b339-c693-4c49-b7e1-6509456c987a"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("b06a4db7-6db3-454c-a593-7d140dad4d90"));

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: new Guid("fea7194f-a9f9-43fa-b811-1c60de5f451b"));

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
    }
}
