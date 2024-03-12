using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberGroup.Data.Migrations
{
    /// <inheritdoc />
    public partial class hej : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ResponseModels",
                columns: new[] { "Id", "IsRightAnswer", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 2, false, 1, "Svar fråga 1" },
                    { 3, true, 1, "Svar fråga 1" },
                    { 4, true, 2, "Svar fråga 2" },
                    { 5, false, 2, "Svar fråga 2" },
                    { 6, false, 2, "Svar fråga 2" },
                    { 7, true, 3, "Svar fråga 3" },
                    { 8, false, 3, "Svar fråga 3" },
                    { 9, false, 3, "Svar fråga 3" }
                });
        }
    }
}
