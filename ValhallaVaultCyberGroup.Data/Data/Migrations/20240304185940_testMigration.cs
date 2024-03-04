using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberGroup.Ui.Migrations
{
    /// <inheritdoc />
    public partial class testMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ResultModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultCategories_Results_ResultModelId",
                        column: x => x.ResultModelId,
                        principalTable: "Results",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResultSegments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ResultCategoryModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultSegments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSegments_ResultCategories_ResultCategoryModelId",
                        column: x => x.ResultCategoryModelId,
                        principalTable: "ResultCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResultSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultSegmentId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ResultSegmentModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSubCategories_ResultSegments_ResultSegmentModelId",
                        column: x => x.ResultSegmentModelId,
                        principalTable: "ResultSegments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResultQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    ResultSubCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    ResultSubCategoryModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultQuestions_ResultSubCategories_ResultSubCategoryModelId",
                        column: x => x.ResultSubCategoryModelId,
                        principalTable: "ResultSubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultCategories_ResultModelId",
                table: "ResultCategories",
                column: "ResultModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultQuestions_ResultSubCategoryModelId",
                table: "ResultQuestions",
                column: "ResultSubCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ApplicationUserId",
                table: "Results",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultSegments_ResultCategoryModelId",
                table: "ResultSegments",
                column: "ResultCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultSubCategories_ResultSegmentModelId",
                table: "ResultSubCategories",
                column: "ResultSegmentModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultQuestions");

            migrationBuilder.DropTable(
                name: "ResultSubCategories");

            migrationBuilder.DropTable(
                name: "ResultSegments");

            migrationBuilder.DropTable(
                name: "ResultCategories");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
