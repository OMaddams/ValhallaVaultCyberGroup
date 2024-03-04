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
                    Name = "Grundläggande IT-säkerhet"
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "Att skydda sig mot bedrägerier"
                },
                new CategoryModel
                {
                    Id = 3,
                    Name = "Cybersäkerhet för företag"
                },
                new CategoryModel
                {
                    Id = 4,
                    Name = "Cyberspionage"
                });

            modelBuilder.Entity<SegmentModel>().HasData(
                new SegmentModel
                {
                    Id = 1,
                    Name = "Segment 1",
                    CategoriesId = 1,
                },
                new SegmentModel
                {
                    Id = 2,
                    Name = "Segment 2",
                    CategoriesId = 2
                },
                new SegmentModel
                {
                    Id = 3,
                    Name = "Segment 3",
                    CategoriesId = 3
                },
                new SegmentModel
                {
                    Id = 4,
                    Name = "Segment 4",
                    CategoriesId = 4
                });

            modelBuilder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel
                {
                    Id = 1,
                    Name = "Allmänt om digital säkerhet",
                    SegmentId = 1
                },
                new SubCategoryModel
                {
                    Id = 2,
                    Name = "Brandväggar och antivirus-program",
                    SegmentId = 1
                },
                new SubCategoryModel
                {
                    Id = 3,
                    Name = "Håll dina program aktuella",
                    SegmentId = 1
                },
                new SubCategoryModel
                {
                    Id = 4,
                    Name = "N/A, Sub-category for Segment 1",
                    SegmentId = 1
                },
                new SubCategoryModel
                {
                    Id = 5,
                    Name = "Skydda din anslutning",
                    SegmentId = 2
                },
                new SubCategoryModel
                {
                    Id = 6,
                    Name = "Ta hand om dina lösenord",
                    SegmentId = 2
                },
                new SubCategoryModel
                {
                    Id = 7,
                    Name = "Var rädd om dina kortuppgifter",
                    SegmentId = 2
                },
                new SubCategoryModel
                {
                    Id = 8,
                    Name = "N/A, Sub-category for Segment 2",
                    SegmentId = 2
                },
                new SubCategoryModel
                {
                    Id = 9,
                    Name = "N/A, Sub-category for Segment 3",
                    SegmentId = 3
                },
                new SubCategoryModel
                {
                    Id = 10,
                    Name = "N/A, Sub-category for Segment 3",
                    SegmentId = 3
                },
                new SubCategoryModel
                {
                    Id = 11,
                    Name = "N/A, Sub-category for Segment 3",
                    SegmentId = 3
                },
                new SubCategoryModel
                {
                    Id = 12,
                    Name = "N/A, Sub-category for Segment 3",
                    SegmentId = 3
                },
                new SubCategoryModel
                {
                    Id = 13,
                    Name = "N/A, Sub-category for Segment 4",
                    SegmentId = 4
                },
                new SubCategoryModel
                {
                    Id = 14,
                    Name = "N/A, Sub-category for Segment 4",
                    SegmentId = 4
                },
                new SubCategoryModel
                {
                    Id = 15,
                    Name = "N/A, Sub-category for Segment 4",
                    SegmentId = 4
                },
                new SubCategoryModel
                {
                    Id = 16,
                    Name = "N/A, Sub-category for Segment 4",
                    SegmentId = 4
                });

            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel
                {
                    Id = 1,
                    Text = "Fråga 1",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 2,
                    Text = "Fråga 2",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 3,
                    Text = "Fråga 3",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 4,
                    Text = "Fråga 4",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 5,
                    Text = "Fråga 5",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 6,
                    Text = "Fråga 6",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 7,
                    Text = "Fråga 7",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 8,
                    Text = "Fråga 8",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 9,
                    Text = "Fråga 9",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 10,
                    Text = "Fråga 10",
                    SubCategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 11,
                    Text = "Fråga 1",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 12,
                    Text = "Fråga 2",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 13,
                    Text = "Fråga 3",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 14,
                    Text = "Fråga 4",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 15,
                    Text = "Fråga 5",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 16,
                    Text = "Fråga 6",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 17,
                    Text = "Fråga 7",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 18,
                    Text = "Fråga 8",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 19,
                    Text = "Fråga 9",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 20,
                    Text = "Fråga 10",
                    SubCategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 21,
                    Text = "Fråga 1",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 22,
                    Text = "Fråga 2",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 23,
                    Text = "Fråga 3",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 24,
                    Text = "Fråga 4",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 25,
                    Text = "Fråga 5",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 26,
                    Text = "Fråga 6",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 27,
                    Text = "Fråga 7",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 28,
                    Text = "Fråga 8",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 29,
                    Text = "Fråga 9",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 30,
                    Text = "Fråga 10",
                    SubCategoryId = 3,
                },
                new QuestionModel
                {
                    Id = 31,
                    Text = "Fråga 1",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 32,
                    Text = "Fråga 2",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 33,
                    Text = "Fråga 3",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 34,
                    Text = "Fråga 4",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 35,
                    Text = "Fråga 5",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 36,
                    Text = "Fråga 6",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 37,
                    Text = "Fråga 7",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 38,
                    Text = "Fråga 8",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 39,
                    Text = "Fråga 9",
                    SubCategoryId = 4,
                },
                new QuestionModel
                {
                    Id = 40,
                    Text = "Fråga 10",
                    SubCategoryId = 4,
                });
        }

    }
}
