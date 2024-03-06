using ValhallaVaultCyberGroup.Ui.Data;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public class ResultRepo : IResultRepo
    {
        private readonly ApplicationDbContext _context;

        public ResultRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CheckSubcategoryProgress(string userId, int subCategoryId)
        {
            var userResults = _context.Results
                .Where(r => r.ApplicationUserId == userId)
                .ToList();

            foreach (var result in userResults)
            {
                foreach (var category in result.ResultsCategories)
                {
                    foreach (var segment in category.ResultSegments)
                    {
                        foreach (var subCategory in segment.ResultSubCategories)
                        {
                            if (subCategory.Id == subCategoryId)
                            {
                                int totalQuestions = subCategory.ResultQuestions.Count;
                                int correctAnswers = subCategory.ResultQuestions.Count(q => q.IsCorrect);
                                if (totalQuestions > 0 && correctAnswers * 100 / totalQuestions >= 80)
                                {
                                    return true;
                                }
                                return false;
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
}
