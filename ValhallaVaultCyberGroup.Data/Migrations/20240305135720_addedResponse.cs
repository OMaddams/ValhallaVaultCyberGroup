using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberGroup.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ResponseModels",
                columns: new[] { "Id", "IsRightAnswer", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "Svar 1" },
                    { 2, true, 2, "Svar 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
