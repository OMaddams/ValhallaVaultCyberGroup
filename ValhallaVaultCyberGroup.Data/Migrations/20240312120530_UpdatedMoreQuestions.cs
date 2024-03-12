using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberGroup.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMoreQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionModels",
                columns: new[] { "Id", "SubCategoryId", "Text", "selectedResponseModelId" },
                values: new object[,]
                {
                    { 15, 1, "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?", 0 },
                    { 16, 1, "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?", 0 },
                    { 17, 1, "Hur kan du bäst skydda dig mot telefonbedrägerier?", 0 },
                    { 18, 12, "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?", 0 },
                    { 19, 12, "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?", 0 },
                    { 20, 12, "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?", 0 },
                    { 21, 37, "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?", 0 },
                    { 22, 37, "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?", 0 },
                    { 23, 37, "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?", 0 }
                });

            migrationBuilder.InsertData(
                table: "ResponseModels",
                columns: new[] { "Id", "IsRightAnswer", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 43, false, 15, "Ge dem informationen de ber om, för säkerhets skull" },
                    { 44, true, 15, "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt" },
                    { 45, false, 15, "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet" },
                    { 46, false, 16, "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering." },
                    { 47, false, 16, "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar." },
                    { 48, true, 16, "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post." },
                    { 49, false, 17, "Installera en app som blockerar misstänkta samtal" },
                    { 50, false, 17, "Aldrig svara på samtal från okända nummer" },
                    { 51, true, 17, "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon" },
                    { 52, false, 18, "Manuellt kontrollera varje anställds lösenord en gång per år" },
                    { 53, true, 18, "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag" },
                    { 54, false, 18, "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem" },
                    { 55, false, 19, "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet" },
                    { 56, true, 19, "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster" },
                    { 57, false, 19, "Endast tillåta anställda att arbeta offline när de inte är på kontoret" },
                    { 58, false, 20, "Blockera all inkommande e-post från externa källor" },
                    { 59, true, 20, "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar" },
                    { 60, false, 20, "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet" },
                    { 61, true, 21, "Öka användningen av kryptering för all intern och extern kommunikation" },
                    { 62, false, 21, "Förbjuda all användning av e-post och återgå till fysisk korrespondens" },
                    { 63, false, 21, "Installera antivirusprogram på alla datorer" },
                    { 64, false, 22, "Genomföra strikta bakgrundskontroller av alla anställda" },
                    { 65, true, 22, "Implementera ett omfattande program för beteendeanalys och anomalidetektering" },
                    { 66, false, 22, "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter" },
                    { 67, false, 23, "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet" },
                    { 68, true, 23, "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna" },
                    { 69, false, 23, "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ResponseModels",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionModels",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
