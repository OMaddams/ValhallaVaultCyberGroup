using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.Data.Data;
using ValhallaVaultCyberGroup.Data.Models.Domain;
using ValhallaVaultCyberGroup.Data.Repositories;

namespace Tests
{
    public class ResultRepoTest : IDisposable
    {
        private readonly IQuestionsRepo repo;
        QuizDbContext QuizDbContext;
        public ResultRepoTest()
        {
            var options = new DbContextOptionsBuilder<QuizDbContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ValhallaQuizDb;Trusted_Connection=True;").Options;
            QuizDbContext = new QuizDbContext(options);
            repo = new QuestionsRepo(QuizDbContext);
        }
        [Fact]
        public async Task CategoryCrudTestAsync()
        {
            CategoryModel category = new CategoryModel();
            category.Name = "CreateTest";
            var returnedCat = await repo.AddCategoryAsync(category);
            await repo.SaveChangesAsync();
            var storedCat = await repo.GetCategoryAsync(category.Name);
            Assert.NotNull(returnedCat);
            Assert.Equal(storedCat, returnedCat);

            returnedCat.Name = "updatedTest";
            var updatedCat = await repo.UpdateCategoryAsync(returnedCat);
            await repo.SaveChangesAsync();
            Assert.NotNull(updatedCat);
            Assert.Equal(returnedCat, updatedCat);

            repo.RemoveCategoryAsync(updatedCat);
            await repo.SaveChangesAsync();

            var removedCat = await repo.GetCategoryAsync(updatedCat.Id);
            Assert.Null(removedCat);
        }



        public void Dispose()
        {
            QuizDbContext.Dispose();
        }
    }
}
