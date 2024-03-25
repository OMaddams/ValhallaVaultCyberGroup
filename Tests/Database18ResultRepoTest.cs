using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ValhallaVaultCyberGroup.Data.Models.Result;
using ValhallaVaultCyberGroup.Data.Repositories;
using ValhallaVaultCyberGroup.Ui.Data;

namespace Tests
{
    public class Database18ResultRepoTest : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly IResultRepo _repository;

        // Använder in-memory databas istället för mocking. Testar mocking i ett annat test.
        public Database18ResultRepoTest()
        {
            _context = InitialDatabase();
            _repository = new ResultRepo(_context);
        }

        private ApplicationDbContext? InitialDatabase()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "aspnet-ValhallaVaultCyberGroup.Ui-f3ed0749-718d-4614-90bb-22841387ea00")
                .UseInternalServiceProvider(serviceProvider)
                .Options;

            return new ApplicationDbContext(options);
        }

        [Fact]
        // Testa för att se om completion är true på metoden CheckSubcategoryCompletion();
        public async Task CheckSubcategoryCompletion1()
        {
            // Arrange
            var userName = "testUser";
            var subCategoryId = 1;
            var subcategory =
                new ResultSubCategoryModel
                {
                    username = userName,
                    SubCategoryModelId = subCategoryId,
                    ResultQuestions = new List<ResultQuestionModel>
                    {
                        // Make sure result on subcategory 1 is 80% or over.
                        new ResultQuestionModel { IsCorrect = true },
                        new ResultQuestionModel { IsCorrect = true },
                        new ResultQuestionModel { IsCorrect = true },
                        new ResultQuestionModel { IsCorrect = true },
                        new ResultQuestionModel { IsCorrect = false }
                    }
                };
            _context.ResultSubCategories.Add(subcategory);
            _context.SaveChanges();

            // Act
            var result = _repository.CheckSubcategoryCompletion(userName, subCategoryId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        // Testa för att se om completion är false på metoden CheckSubcategoryCompletion();
        public async Task CheckSubcategoryCompletion2()
        {
            // Arrange
            var userId = "testUser";
            var subCategoryId = 2;
            var subcategory = new ResultSubCategoryModel
            {
                username = userId,
                SubCategoryModelId = subCategoryId,
                ResultQuestions = new List<ResultQuestionModel>
                {
                    // Make sure result on subcategory 2 is 80% or lower.
                    new ResultQuestionModel { IsCorrect = true },
                    new ResultQuestionModel { IsCorrect = true },
                    new ResultQuestionModel { IsCorrect = true },
                    new ResultQuestionModel { IsCorrect = false },
                    new ResultQuestionModel { IsCorrect = false }
                }
            };
            _context.ResultSubCategories.Add(subcategory);
            await _context.SaveChangesAsync();

            // Act
            var result = _repository.CheckSubcategoryCompletion(userId, subCategoryId);

            // Assert
            Assert.False(result);
        }




        public void Dispose()
        {
            _context.Dispose();
        }
    }
}