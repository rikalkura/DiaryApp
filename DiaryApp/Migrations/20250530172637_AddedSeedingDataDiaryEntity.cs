using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntities",
                columns: new[] { "Id", "CreatedAt", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed just now", "Completed .Net course" },
                    { 2, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Played archero for 5 minutes", "Played Archero" },
                    { 3, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watched youtube for 10 minutes", "Watched youtube" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntities",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
