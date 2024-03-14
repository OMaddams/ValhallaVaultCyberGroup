using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.Data.Models.AdminConnection;
using ValhallaVaultCyberGroup.Data.Models.Result;


namespace ValhallaVaultCyberGroup.Ui.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {


        public DbSet<ResultModel> Results { get; set; }

        public DbSet<ResultSegmentModel> ResultSegments { get; set; }
        public DbSet<ResultSubCategoryModel> ResultSubCategories { get; set; }
        public DbSet<ResultQuestionModel> ResultQuestions { get; set; }

        public DbSet<AdminConnectionModel> AdminConnections { get; set; }
    }
}
