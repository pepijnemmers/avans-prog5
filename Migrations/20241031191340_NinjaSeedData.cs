using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaApp.Migrations
{
    /// <inheritdoc />
    public partial class NinjaSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
