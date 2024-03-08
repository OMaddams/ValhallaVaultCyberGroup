using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.Data.Models.Domain;
using ValhallaVaultCyberGroup.Ui.Data;

namespace ValhallaVaultCyberGroup.Data.Data
{
    public class QuizDbContext(DbContextOptions<QuizDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> CategoryModels { get; set; }
        public DbSet<QuestionModel> QuestionModels { get; set; }
        public DbSet<ResponseModel> ResponseModels { get; set; }
        public DbSet<SegmentModel> SegmentModels { get; set; }
        public DbSet<SubCategoryModel> SubCategoryModels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    Id = 1,
                    Name = "Att skydda sig mot bedrägerier"
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "Cybersäkerhet för företag"
                },
                new CategoryModel
                {
                    Id = 3,
                    Name = "Cyberspionage"
                });

            modelBuilder.Entity<SegmentModel>().HasData(
                new SegmentModel
                {
                    Id = 1,
                    Name = "Del 1",
                    CategoriesId = 1,

                },
                new SegmentModel
                {
                    Id = 2,
                    Name = "Del 2",
                    CategoriesId = 1,
                    PreviousSegmentId = 1,
                },
                new SegmentModel
                {
                    Id = 3,
                    Name = "Del 3",
                    CategoriesId = 1,
                    PreviousSegmentId = 2,
                },
                new SegmentModel
                {
                    Id = 4,
                    Name = "Del 1",
                    CategoriesId = 2
                },
                new SegmentModel
                {
                    Id = 5,
                    Name = "Del 2",
                    CategoriesId = 2,
                    PreviousSegmentId = 4

                },
                new SegmentModel
                {
                    Id = 6,
                    Name = "Del 3",
                    CategoriesId = 2,
                    PreviousSegmentId = 5
                },
                new SegmentModel
                {
                    Id = 7,
                    Name = "Del 4",
                    CategoriesId = 2,
                    PreviousSegmentId = 6
                },
                new SegmentModel
                {
                    Id = 8,
                    Name = "Del 1",
                    CategoriesId = 3,

                },
                new SegmentModel
                {
                    Id = 9,
                    Name = "Del 2",
                    CategoriesId = 3,
                    PreviousSegmentId = 8
                },
                new SegmentModel
                {
                    Id = 10,
                    Name = "Del 3",
                    CategoriesId = 3,
                    PreviousSegmentId = 9
                });

            modelBuilder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel
                {
                    Id = 1,
                    Name = "Kreditkortsbedrägeri",
                    SegmentId = 1
                },
                new SubCategoryModel
                {
                    Id = 2,
                    Name = "Romansbedrägeri",
                    SegmentId = 1,
                    PreviousSubCategoryId = 1
                },
                new SubCategoryModel
                {
                    Id = 3,
                    Name = "Investeringsbedrägeri",
                    SegmentId = 1,
                    PreviousSubCategoryId = 2
                },
                new SubCategoryModel
                {
                    Id = 4,
                    Name = "Telefonbedrägeri",
                    SegmentId = 1,
                    PreviousSubCategoryId = 3
                },
                new SubCategoryModel
                {
                    Id = 5,
                    Name = "Bedrägeri i hemmet",
                    SegmentId = 2
                },
                new SubCategoryModel
                {
                    Id = 6,
                    Name = "Identitetsstöld",
                    SegmentId = 2,
                    PreviousSubCategoryId = 5
                },
                new SubCategoryModel
                {
                    Id = 7,
                    Name = "Nätfiske och bluffmejl",
                    SegmentId = 2,
                    PreviousSubCategoryId = 6
                },
                new SubCategoryModel
                {
                    Id = 8,
                    Name = "Investeringsbedrägeri på nätet",
                    SegmentId = 2,
                    PreviousSubCategoryId = 7
                },
                new SubCategoryModel
                {
                    Id = 9,
                    Name = "Abonnemangsfällor och falska fakturor",
                    SegmentId = 3
                },
                new SubCategoryModel
                {
                    Id = 10,
                    Name = "Ransomware",
                    SegmentId = 3,
                    PreviousSubCategoryId = 9
                },
                new SubCategoryModel
                {
                    Id = 11,
                    Name = "Statistik och förhållningssätt",
                    SegmentId = 3,
                    PreviousSubCategoryId = 10
                },
                new SubCategoryModel
                {
                    Id = 12,
                    Name = "Digital säkerhet på företag",
                    SegmentId = 4
                },
                new SubCategoryModel
                {
                    Id = 13,
                    Name = "Risker och beredskap",
                    SegmentId = 4,
                    PreviousSubCategoryId = 12
                },
                new SubCategoryModel
                {
                    Id = 14,
                    Name = "Aktörer inom cyberbrott",
                    SegmentId = 4,
                    PreviousSubCategoryId = 13
                },
                new SubCategoryModel
                {
                    Id = 15,
                    Name = "Ökad digital närvaro och distansarbete",
                    SegmentId = 4,
                    PreviousSubCategoryId = 14
                },
                new SubCategoryModel
                {
                    Id = 16,
                    Name = "Cyberangrepp mot känsliga sektorer",
                    SegmentId = 4,
                    PreviousSubCategoryId = 15
                },
                new SubCategoryModel
                {
                    Id = 17,
                    Name = "Cyberrånet mot Mersk Cyberrånet mot Mersk ",
                    SegmentId = 4,
                    PreviousSubCategoryId = 16
                },
                new SubCategoryModel
                {
                    Id = 18,
                    Name = "Social engineering",
                    SegmentId = 5
                },
                new SubCategoryModel
                {
                    Id = 19,
                    Name = "Nätfiske och skräppost",
                    SegmentId = 5,
                    PreviousSubCategoryId = 18
                },
                new SubCategoryModel
                {
                    Id = 20,
                    Name = "Vishing",
                    SegmentId = 5,
                    PreviousSubCategoryId = 19
                },
                new SubCategoryModel
                {
                    Id = 21,
                    Name = "Varning för vishing",
                    SegmentId = 5,
                    PreviousSubCategoryId = 20
                },
                new SubCategoryModel
                {
                    Id = 22,
                    Name = "Identifiera VD-mejl",
                    SegmentId = 5,
                    PreviousSubCategoryId = 21
                },
                new SubCategoryModel
                {
                    Id = 23,
                    Name = "Öneangrepp och presentkortsbluffar",
                    SegmentId = 5,
                    PreviousSubCategoryId = 22
                },
                new SubCategoryModel
                {
                    Id = 25,
                    Name = "Virus, maskar och trojaner",
                    SegmentId = 6
                },
                new SubCategoryModel
                {
                    Id = 26,
                    Name = "Så kan det gå till",
                    SegmentId = 6,
                    PreviousSubCategoryId = 25
                },
                new SubCategoryModel
                {
                    Id = 27,
                    Name = "Nätverksintrång",
                    SegmentId = 6,
                    PreviousSubCategoryId = 26
                },
                new SubCategoryModel
                {
                    Id = 28,
                    Name = "Dataintrång",
                    SegmentId = 6,
                    PreviousSubCategoryId = 27
                },
                new SubCategoryModel
                {
                    Id = 29,
                    Name = "Hackad!",
                    SegmentId = 6,
                    PreviousSubCategoryId = 28
                },
                new SubCategoryModel
                {
                    Id = 30,
                    Name = "Vägarna in",
                    SegmentId = 6,
                    PreviousSubCategoryId = 29
                },
                new SubCategoryModel
                {
                    Id = 31,
                    Name = "Utpressningsvirus",
                    SegmentId = 7
                },
                new SubCategoryModel
                {
                    Id = 32,
                    Name = "Attacker mot servrar",
                    SegmentId = 7,
                    PreviousSubCategoryId = 31
                },
                new SubCategoryModel
                {
                    Id = 33,
                    Name = "Cyberangrepp i Norden",
                    SegmentId = 7,
                    PreviousSubCategoryId = 32
                },
                new SubCategoryModel
                {
                    Id = 34,
                    Name = "It-brottslingarnas verktyg",
                    SegmentId = 7,
                    PreviousSubCategoryId = 33
                },
                new SubCategoryModel
                {
                    Id = 35,
                    Name = "Mirai, Wannacry och fallet Düsseldorf",
                    SegmentId = 7,
                    PreviousSubCategoryId = 34
                },
                new SubCategoryModel
                {
                    Id = 36,
                    Name = "De sårbara molnen",
                    SegmentId = 7,
                    PreviousSubCategoryId = 35
                },
                new SubCategoryModel
                {
                    Id = 37,
                    Name = "Allmänt om cyberspionage",
                    SegmentId = 8
                },
                new SubCategoryModel
                {
                    Id = 38,
                    Name = "Metoder för cyberspionage",
                    SegmentId = 8,
                    PreviousSubCategoryId = 37
                },
                new SubCategoryModel
                {
                    Id = 39,
                    Name = "Säkerhetsskyddslagen",
                    SegmentId = 8,
                    PreviousSubCategoryId = 38
                },
                new SubCategoryModel
                {
                    Id = 40,
                    Name = "Cyberspionagets aktörer",
                    SegmentId = 8,
                    PreviousSubCategoryId = 39
                },
                new SubCategoryModel
                {
                    Id = 41,
                    Name = "Värvningsförsök",
                    SegmentId = 9
                },
                new SubCategoryModel
                {
                    Id = 42,
                    Name = "Affärsspionage",
                    SegmentId = 9,
                    PreviousSubCategoryId = 41
                },
                new SubCategoryModel
                {
                    Id = 43,
                    Name = "Påverkanskampanjer",
                    SegmentId = 9,
                    PreviousSubCategoryId = 42
                },
                new SubCategoryModel
                {
                    Id = 44,
                    Name = "Svensk underrättelsetjänst och cyberförsvar",
                    SegmentId = 10
                },
                new SubCategoryModel
                {
                    Id = 45,
                    Name = "Signalspaning, informationssäkerhet och 5G",
                    SegmentId = 10,
                    PreviousSubCategoryId = 44
                },
                new SubCategoryModel
                {
                    Id = 46,
                    Name = "Samverkan mot cyberspionage",
                    SegmentId = 10,
                    PreviousSubCategoryId = 45
                });


            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel
                {
                    Id = 1,
                    Text = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 2,
                    Text = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 3,
                    Text = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 4,
                    Text = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 5,
                    Text = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    SubCategoryId = 12
                },
                new QuestionModel
                {
                    Id = 6,
                    Text = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                    SubCategoryId = 13,
                },
                new QuestionModel
                {
                    Id = 7,
                    Text = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                    SubCategoryId = 14,
                },
                new QuestionModel
                {
                    Id = 8,
                    Text = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                    SubCategoryId = 15,
                },
                new QuestionModel
                {
                    Id = 9,
                    Text = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                    SubCategoryId = 16,
                },
                new QuestionModel
                {
                    Id = 10,
                    Text = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                    SubCategoryId = 17,
                },
                new QuestionModel
                {
                    Id = 11,
                    Text = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                    SubCategoryId = 37,
                },
                new QuestionModel
                {
                    Id = 12,
                    Text = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                    SubCategoryId = 38,
                },
                new QuestionModel
                {
                    Id = 13,
                    Text = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                    SubCategoryId = 39,
                },
                new QuestionModel
                {
                    Id = 14,
                    Text = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                    SubCategoryId = 40,
                });


            modelBuilder.Entity<ResponseModel>().HasData(

                new ResponseModel
                {
                    Id = 10,
                    Text = "Cyberkriminalitet",
                    IsRightAnswer = false,
                    QuestionId = 11,
                },
                new ResponseModel
                {
                    Id = 11,
                    Text = "Cyberspionage",
                    IsRightAnswer = true,
                    QuestionId = 11,
                },
                new ResponseModel
                {
                    Id = 12,
                    Text = "Cyberterrorism",
                    IsRightAnswer = false,
                    QuestionId = 11,
                },
                new ResponseModel
                {
                    Id = 13,
                    Text = "Spyware",
                    IsRightAnswer = false,
                    QuestionId = 10,
                },
                new ResponseModel
                {
                    Id = 14,
                    Text = "Ransomware",
                    IsRightAnswer = true,
                    QuestionId = 10,
                },
                new ResponseModel
                {
                    Id = 15,
                    Text = "Adware",
                    IsRightAnswer = false,
                    QuestionId = 10,
                },
                new ResponseModel
                {
                    Id = 16,
                    Text = "Phishing",
                    IsRightAnswer = false,
                    QuestionId = 9,
                },
                new ResponseModel
                {
                    Id = 17,
                    Text = "Ransomware",
                    IsRightAnswer = true,
                    QuestionId = 9,
                },
                new ResponseModel
                {
                    Id = 18,
                    Text = "Spyware",
                    IsRightAnswer = false,
                    QuestionId = 9,
                },
                new ResponseModel
                {
                    Id = 19,
                    Text = "Återgå till kontorsarbete",
                    IsRightAnswer = false,
                    QuestionId = 8,
                },
                new ResponseModel
                {
                    Id = 20,
                    Text = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    IsRightAnswer = true,
                    QuestionId = 8,
                },
                new ResponseModel
                {
                    Id = 21,
                    Text = "Förbjuda användning av personliga enheter för arbete",
                    IsRightAnswer = false,
                    QuestionId = 8,
                },
                new ResponseModel
                {
                    Id = 22,
                    Text = "En enskild hackare med ett personligt vendetta",
                    IsRightAnswer = false,
                    QuestionId = 7,
                },
                new ResponseModel
                {
                    Id = 23,
                    Text = "En konkurrerande företagsentitet",
                    IsRightAnswer = false,
                    QuestionId = 7,
                },
                new ResponseModel
                {
                    Id = 24,
                    Text = "Organiserade cyberbrottsliga grupper",
                    IsRightAnswer = true,
                    QuestionId = 7,
                },
                new ResponseModel
                {
                    Id = 25,
                    Text = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                    IsRightAnswer = true,
                    QuestionId = 6,
                },
                new ResponseModel
                {
                    Id = 26,
                    Text = "Ignorera problemet tills en patch kan utvecklas",
                    IsRightAnswer = false,
                    QuestionId = 6,
                },
                new ResponseModel
                {
                    Id = 27,
                    Text = "Stänga ner tjänsten tillfälligt",
                    IsRightAnswer = false,
                    QuestionId = 6,
                },
                new ResponseModel
                {
                    Id = 28,
                    Text = "Utbildning i digital säkerhet för alla anställda",
                    IsRightAnswer = true,
                    QuestionId = 5,
                },
                new ResponseModel
                {
                    Id = 29,
                    Text = "Installera en starkare brandvägg",
                    IsRightAnswer = false,
                    QuestionId = 5,
                },
                new ResponseModel
                {
                    Id = 30,
                    Text = "Byta ut all IT-utrustning",
                    IsRightAnswer = false,
                    QuestionId = 5,
                },
                new ResponseModel
                {
                    Id = 31,
                    Text = "Ett misstag av kreditkortsföretaget",
                    IsRightAnswer = false,
                    QuestionId = 4,
                },
                new ResponseModel
                {
                    Id = 32,
                    Text = "Kreditkortsbedrägeri",
                    IsRightAnswer = true,
                    QuestionId = 4,
                },
                new ResponseModel
                {
                    Id = 33,
                    Text = "Obehöriga köp av en familjemedlem",
                    IsRightAnswer = false,
                    QuestionId = 4,
                },
                new ResponseModel
                {
                    Id = 34,
                    Text = "Genomföra omedelbar investering för att inte missa möjligheten",
                    IsRightAnswer = false,
                    QuestionId = 3,
                },
                new ResponseModel
                {
                    Id = 35,
                    Text = "Investeringsbedrägeri",
                    IsRightAnswer = true,
                    QuestionId = 3,
                },
                new ResponseModel
                {
                    Id = 36,
                    Text = "Begära mer information för att utföra en noggrann due diligence",
                    IsRightAnswer = false,
                    QuestionId = 3,
                },
                new ResponseModel
                {
                    Id = 37,
                    Text = "En legitim begäran om hjälp från en person i nöd",
                    IsRightAnswer = false,
                    QuestionId = 2,
                },
                new ResponseModel
                {
                    Id = 38,
                    Text = "Ett romansbedrägeri",
                    IsRightAnswer = true,
                    QuestionId = 2,
                },
                new ResponseModel
                {
                    Id = 39,
                    Text = "En tillfällig ekonomisk svårighet",
                    IsRightAnswer = false,
                    QuestionId = 2,
                },
                new ResponseModel
                {
                    Id = 40,
                    Text = "Ett legitimt försök från banken att skydda ditt konto",
                    IsRightAnswer = false,
                    QuestionId = 1,
                },
                new ResponseModel
                {

                    Id = 41,
                    Text = "En informationsinsamling för en marknadsundersökning",

                    IsRightAnswer = false,
                    QuestionId = 1,
                },
                new ResponseModel
                {

                    Id = 2,
                    Text = "Svar fråga 1",
                    IsRightAnswer = false,
                    QuestionId = 1,
                },
                new ResponseModel
                {
                    Id = 3,
                    Text = "Svar fråga 1",
                    IsRightAnswer = true,
                    QuestionId = 1,
                },
                new ResponseModel
                {
                    Id = 4,
                    Text = "Svar fråga 2",
                    IsRightAnswer = true,
                    QuestionId = 2,
                }, new ResponseModel
                {
                    Id = 5,
                    Text = "Svar fråga 2",
                    IsRightAnswer = false,
                    QuestionId = 2,
                },
                new ResponseModel
                {
                    Id = 6,
                    Text = "Svar fråga 2",
                    IsRightAnswer = false,
                    QuestionId = 2,
                }, new ResponseModel
                {
                    Id = 7,
                    Text = "Svar fråga 3",
                    IsRightAnswer = true,
                    QuestionId = 3,
                },
                new ResponseModel
                {
                    Id = 8,
                    Text = "Svar fråga 3",
                    IsRightAnswer = false,
                    QuestionId = 3,
                }, new ResponseModel
                {
                    Id = 9,
                    Text = "Svar fråga 3",
                    IsRightAnswer = false,
                    QuestionId = 3,
                }, new ResponseModel
                {

                    Id = 42,
                    Text = "Ett potentiellt telefonbedrägeri",
                    IsRightAnswer = true,
                    QuestionId = 1,

                });
        }

    }
}
