using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberGroup.Data.Migrations.QuizDb
{
    /// <inheritdoc />
    public partial class haha : Migration
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
                name: "ResultSegmentModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultModelId = table.Column<int>(type: "int", nullable: false),
                    SegmentModelId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultSegmentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSegmentModel_ResultModel_ResultModelId",
                        column: x => x.ResultModelId,
                        principalTable: "ResultModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ResultSubCategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultSegmentModelId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryModelId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultSubCategoryModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultSubCategoryModel_ResultSegmentModel_ResultSegmentModelId",
                        column: x => x.ResultSegmentModelId,
                        principalTable: "ResultSegmentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    selectedResponseModelId = table.Column<int>(type: "int", nullable: false),
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
                name: "ResultQuestionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionModelId = table.Column<int>(type: "int", nullable: false),
                    ResultSubCategoryModelId = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultQuestionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultQuestionModel_ResultSubCategoryModel_ResultSubCategoryModelId",
                        column: x => x.ResultSubCategoryModelId,
                        principalTable: "ResultSubCategoryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "CategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Att skydda sig mot bedrägerier" },
                    { 2, "Cybersäkerhet för företag" },
                    { 3, "Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "SegmentModels",
                columns: new[] { "Id", "CategoriesId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Del 1" },
                    { 2, 1, "Del 2" },
                    { 3, 1, "Del 3" },
                    { 4, 2, "Del 1" },
                    { 5, 2, "Del 2" },
                    { 6, 2, "Del 3" },
                    { 7, 2, "Del 4" },
                    { 8, 3, "Del 1" },
                    { 9, 3, "Del 2" },
                    { 10, 3, "Del 3" }
                });

            migrationBuilder.InsertData(
                table: "SubCategoryModels",
                columns: new[] { "Id", "Name", "SegmentId" },
                values: new object[,]
                {
                    { 1, "Kreditkortsbedrägeri", 1 },
                    { 2, "Romansbedrägeri", 1 },
                    { 3, "Investeringsbedrägeri", 1 },
                    { 4, "Telefonbedrägeri", 1 },
                    { 5, "Bedrägeri i hemmet", 2 },
                    { 6, "Identitetsstöld", 2 },
                    { 7, "Nätfiske och bluffmejl", 2 },
                    { 8, "Investeringsbedrägeri på nätet", 2 },
                    { 9, "Abonnemangsfällor och falska fakturor", 3 },
                    { 10, "Ransomware", 3 },
                    { 11, "Statistik och förhållningssätt", 3 },
                    { 12, "Digital säkerhet på företag", 4 },
                    { 13, "Risker och beredskap", 4 },
                    { 14, "Aktörer inom cyberbrott", 4 },
                    { 15, "Ökad digital närvaro och distansarbete", 4 },
                    { 16, "Cyberangrepp mot känsliga sektorer", 4 },
                    { 17, "Cyberrånet mot Mersk Cyberrånet mot Mersk ", 4 },
                    { 18, "Social engineering", 5 },
                    { 19, "Nätfiske och skräppost", 5 },
                    { 20, "Vishing", 5 },
                    { 21, "Varning för vishing", 5 },
                    { 22, "Identifiera VD-mejl", 5 },
                    { 23, "Öneangrepp och presentkortsbluffar", 5 },
                    { 25, "Virus, maskar och trojaner", 6 },
                    { 26, "Så kan det gå till", 6 },
                    { 27, "Nätverksintrång", 6 },
                    { 28, "Dataintrång", 6 },
                    { 29, "Hackad!", 6 },
                    { 30, "Vägarna in", 6 },
                    { 31, "Utpressningsvirus", 7 },
                    { 32, "Attacker mot servrar", 7 },
                    { 33, "Cyberangrepp i Norden", 7 },
                    { 34, "It-brottslingarnas verktyg", 7 },
                    { 35, "Mirai, Wannacry och fallet Düsseldorf", 7 },
                    { 36, "De sårbara molnen", 7 },
                    { 37, "Allmänt om cyberspionage", 8 },
                    { 38, "Metoder för cyberspionage", 8 },
                    { 39, "Säkerhetsskyddslagen", 8 },
                    { 40, "Cyberspionagets aktörer", 8 },
                    { 41, "Värvningsförsök", 9 },
                    { 42, "Affärsspionage", 9 },
                    { 43, "Påverkanskampanjer", 9 },
                    { 44, "Svensk underrättelsetjänst och cyberförsvar", 10 },
                    { 45, "Signalspaning, informationssäkerhet och 5G", 10 },
                    { 46, "Samverkan mot cyberspionage", 10 }
                });

            migrationBuilder.InsertData(
                table: "QuestionModels",
                columns: new[] { "Id", "SubCategoryId", "Text", "selectedResponseModelId" },
                values: new object[,]
                {
                    { 1, 1, "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?", 0 },
                    { 2, 2, "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?", 0 },
                    { 3, 3, "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?", 0 },
                    { 4, 4, "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 0 },
                    { 5, 12, "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 0 },
                    { 6, 13, "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?", 0 },
                    { 7, 14, "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?", 0 },
                    { 8, 15, "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?", 0 },
                    { 9, 16, "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?", 0 },
                    { 10, 17, "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?", 0 },
                    { 11, 37, "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?", 0 },
                    { 12, 38, "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?", 0 },
                    { 13, 39, "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?", 0 },
                    { 14, 40, "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?", 0 }
                });

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
                    { 9, false, 3, "Svar fråga 3" },
                    { 10, false, 11, "Cyberkriminalitet" },
                    { 11, true, 11, "Cyberspionage" },
                    { 12, false, 11, "Cyberterrorism" },
                    { 13, false, 10, "Spyware" },
                    { 14, true, 10, "Ransomware" },
                    { 15, false, 10, "Adware" },
                    { 16, false, 9, "Phishing" },
                    { 17, true, 9, "Ransomware" },
                    { 18, false, 9, "Spyware" },
                    { 19, false, 8, "Återgå till kontorsarbete" },
                    { 20, true, 8, "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst" },
                    { 21, false, 8, "Förbjuda användning av personliga enheter för arbete" },
                    { 22, false, 7, "En enskild hackare med ett personligt vendetta" },
                    { 23, false, 7, "En konkurrerande företagsentitet" },
                    { 24, true, 7, "Organiserade cyberbrottsliga grupper" },
                    { 25, true, 6, "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder" },
                    { 26, false, 6, "Ignorera problemet tills en patch kan utvecklas" },
                    { 27, false, 6, "Stänga ner tjänsten tillfälligt" },
                    { 28, true, 5, "Utbildning i digital säkerhet för alla anställda" },
                    { 29, false, 5, "Installera en starkare brandvägg" },
                    { 30, false, 5, "Byta ut all IT-utrustning" },
                    { 31, false, 4, "Ett misstag av kreditkortsföretaget" },
                    { 32, true, 4, "Kreditkortsbedrägeri" },
                    { 33, false, 4, "Obehöriga köp av en familjemedlem" },
                    { 34, false, 3, "Genomföra omedelbar investering för att inte missa möjligheten" },
                    { 35, true, 3, "Investeringsbedrägeri" },
                    { 36, false, 3, "Begära mer information för att utföra en noggrann due diligence" },
                    { 37, false, 2, "En legitim begäran om hjälp från en person i nöd" },
                    { 38, true, 2, "Ett romansbedrägeri" },
                    { 39, false, 2, "En tillfällig ekonomisk svårighet" },
                    { 40, false, 1, "Ett legitimt försök från banken att skydda ditt konto" },
                    { 41, false, 1, "En informationsinsamling för en marknadsundersökning" },
                    { 42, true, 1, "Ett potentiellt telefonbedrägeri" }
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
                name: "IX_ResultModel_ApplicationUserId",
                table: "ResultModel",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultQuestionModel_ResultSubCategoryModelId",
                table: "ResultQuestionModel",
                column: "ResultSubCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultSegmentModel_ResultModelId",
                table: "ResultSegmentModel",
                column: "ResultModelId");

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
                name: "ResultModel");

            migrationBuilder.DropTable(
                name: "CategoryModels");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
