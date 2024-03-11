using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberGroup.Data.Migrations
{
    /// <inheritdoc />
    public partial class previousTrackerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviousSubCategoryId",
                table: "SubCategoryModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousSegmentId",
                table: "SegmentModels",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 6,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 8,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 9,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SegmentModels",
                keyColumn: "Id",
                keyValue: 10,
                column: "PreviousSegmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 6,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 7,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 8,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 9,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 10,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 11,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 12,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 13,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 14,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 15,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 16,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 17,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 18,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 19,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 20,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 21,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 22,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 23,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 25,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 26,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 27,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 28,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 29,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 30,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 31,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 32,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 33,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 34,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 35,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 36,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 37,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 38,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 39,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 40,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 41,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 42,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 43,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 44,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 45,
                column: "PreviousSubCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCategoryModels",
                keyColumn: "Id",
                keyValue: 46,
                column: "PreviousSubCategoryId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviousSubCategoryId",
                table: "SubCategoryModels");

            migrationBuilder.DropColumn(
                name: "PreviousSegmentId",
                table: "SegmentModels");
        }
    }
}
