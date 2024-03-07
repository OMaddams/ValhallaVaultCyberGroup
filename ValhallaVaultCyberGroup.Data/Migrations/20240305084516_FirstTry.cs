using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberGroup.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultModel_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SegmentModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SegmentModels_CategoryModels_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "CategoryModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultCategoryModel",
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
                    table.PrimaryKey("PK_ResultCategoryModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultCategoryModel_ResultModel_ResultModelId",
                        column: x => x.ResultModelId,
                        principalTable: "ResultModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryModels_SegmentModels_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "SegmentModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultSegmentModel",
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
                    table.PrimaryKey("PK_ResultSegmentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSegmentModel_ResultCategoryModel_ResultCategoryModelId",
                        column: x => x.ResultCategoryModelId,
                        principalTable: "ResultCategoryModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionModels_SubCategoryModels_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategoryModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultSubCategoryModel",
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
                    table.PrimaryKey("PK_ResultSubCategoryModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSubCategoryModel_ResultSegmentModel_ResultSegmentModelId",
                        column: x => x.ResultSegmentModelId,
                        principalTable: "ResultSegmentModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResponseModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRightAnswer = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseModels_QuestionModels_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultQuestionModel",
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
                    table.PrimaryKey("PK_ResultQuestionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultQuestionModel_ResultSubCategoryModel_ResultSubCategoryModelId",
                        column: x => x.ResultSubCategoryModelId,
                        principalTable: "ResultSubCategoryModel",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Grundläggande IT-säkerhet" },
                    { 2, "Att skydda sig mot bedrägerier" },
                    { 3, "Cybersäkerhet för företag" },
                    { 4, "Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "SegmentModels",
                columns: new[] { "Id", "CategoriesId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Segment 1" },
                    { 2, 2, "Segment 2" },
                    { 3, 3, "Segment 3" },
                    { 4, 4, "Segment 4" }
                });

            migrationBuilder.InsertData(
                table: "SubCategoryModels",
                columns: new[] { "Id", "Name", "SegmentId" },
                values: new object[,]
                {
                    { 1, "Allmänt om digital säkerhet", 1 },
                    { 2, "Brandväggar och antivirus-program", 1 },
                    { 3, "Håll dina program aktuella", 1 },
                    { 4, "N/A, Sub-category for Segment 1", 1 },
                    { 5, "Skydda din anslutning", 2 },
                    { 6, "Ta hand om dina lösenord", 2 },
                    { 7, "Var rädd om dina kortuppgifter", 2 },
                    { 8, "N/A, Sub-category for Segment 2", 2 },
                    { 9, "N/A, Sub-category for Segment 3", 3 },
                    { 10, "N/A, Sub-category for Segment 3", 3 },
                    { 11, "N/A, Sub-category for Segment 3", 3 },
                    { 12, "N/A, Sub-category for Segment 3", 3 },
                    { 13, "N/A, Sub-category for Segment 4", 4 },
                    { 14, "N/A, Sub-category for Segment 4", 4 },
                    { 15, "N/A, Sub-category for Segment 4", 4 },
                    { 16, "N/A, Sub-category for Segment 4", 4 }
                });

            migrationBuilder.InsertData(
                table: "QuestionModels",
                columns: new[] { "Id", "SubCategoryId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Fråga 1" },
                    { 2, 1, "Fråga 2" },
                    { 3, 1, "Fråga 3" },
                    { 4, 1, "Fråga 4" },
                    { 5, 1, "Fråga 5" },
                    { 6, 1, "Fråga 6" },
                    { 7, 1, "Fråga 7" },
                    { 8, 1, "Fråga 8" },
                    { 9, 1, "Fråga 9" },
                    { 10, 1, "Fråga 10" },
                    { 11, 2, "Fråga 1" },
                    { 12, 2, "Fråga 2" },
                    { 13, 2, "Fråga 3" },
                    { 14, 2, "Fråga 4" },
                    { 15, 2, "Fråga 5" },
                    { 16, 2, "Fråga 6" },
                    { 17, 2, "Fråga 7" },
                    { 18, 2, "Fråga 8" },
                    { 19, 2, "Fråga 9" },
                    { 20, 2, "Fråga 10" },
                    { 21, 3, "Fråga 1" },
                    { 22, 3, "Fråga 2" },
                    { 23, 3, "Fråga 3" },
                    { 24, 3, "Fråga 4" },
                    { 25, 3, "Fråga 5" },
                    { 26, 3, "Fråga 6" },
                    { 27, 3, "Fråga 7" },
                    { 28, 3, "Fråga 8" },
                    { 29, 3, "Fråga 9" },
                    { 30, 3, "Fråga 10" },
                    { 31, 4, "Fråga 1" },
                    { 32, 4, "Fråga 2" },
                    { 33, 4, "Fråga 3" },
                    { 34, 4, "Fråga 4" },
                    { 35, 4, "Fråga 5" },
                    { 36, 4, "Fråga 6" },
                    { 37, 4, "Fråga 7" },
                    { 38, 4, "Fråga 8" },
                    { 39, 4, "Fråga 9" },
                    { 40, 4, "Fråga 10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModels_SubCategoryId",
                table: "QuestionModels",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseModels_QuestionId",
                table: "ResponseModels",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultCategoryModel_ResultModelId",
                table: "ResultCategoryModel",
                column: "ResultModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultModel_ApplicationUserId",
                table: "ResultModel",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultQuestionModel_ResultSubCategoryModelId",
                table: "ResultQuestionModel",
                column: "ResultSubCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultSegmentModel_ResultCategoryModelId",
                table: "ResultSegmentModel",
                column: "ResultCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultSubCategoryModel_ResultSegmentModelId",
                table: "ResultSubCategoryModel",
                column: "ResultSegmentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentModels_CategoriesId",
                table: "SegmentModels",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryModels_SegmentId",
                table: "SubCategoryModels",
                column: "SegmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ResponseModels");

            migrationBuilder.DropTable(
                name: "ResultQuestionModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "QuestionModels");

            migrationBuilder.DropTable(
                name: "ResultSubCategoryModel");

            migrationBuilder.DropTable(
                name: "SubCategoryModels");

            migrationBuilder.DropTable(
                name: "ResultSegmentModel");

            migrationBuilder.DropTable(
                name: "SegmentModels");

            migrationBuilder.DropTable(
                name: "ResultCategoryModel");

            migrationBuilder.DropTable(
                name: "CategoryModels");

            migrationBuilder.DropTable(
                name: "ResultModel");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
