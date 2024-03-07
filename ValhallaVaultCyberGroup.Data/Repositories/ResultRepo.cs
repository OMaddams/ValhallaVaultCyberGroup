
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.Data.Models.Result;
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
            //var userResults = _context.Results
            //    .Where(r => r.ApplicationUserId == userId)
            //    .ToList();

            //foreach (var result in userResults)
            //{
            //    foreach (var category in result.ResultsCategories)
            //    {
            //        foreach (var segment in category.ResultSegments)
            //        {
            //            foreach (var subCategory in segment.ResultSubCategories)
            //            {
            //                if (subCategory.Id == subCategoryId)
            //                {
            //                    int totalQuestions = subCategory.ResultQuestions.Count;
            //                    int correctAnswers = subCategory.ResultQuestions.Count(q => q.IsCorrect);
            //                    if (totalQuestions > 0 && correctAnswers * 100 / totalQuestions >= 80)
            //                    {
            //                        return true;
            //                    }
            //                    return false;
            //                }
            //            }
            //        }
            //    }
            //}

            return false;
        }

        //public async Task<ResultModel?> GetResultByIdAsync(int resultId)
        //{
        //    return await _context.Results
        //        .Include(r => r.ResultsCategories)
        //            .ThenInclude(c => c.ResultSegments)
        //                .ThenInclude(s => s.ResultSubCategories)
        //                    .ThenInclude(sc => sc.ResultQuestions)
        //        .FirstOrDefaultAsync(r => r.Id == resultId);
        //}

        public async Task AddResultAsync(ResultModel result)
        {
            await _context.Results.AddAsync(result);
            //await _context.SaveChangesAsync();
        }

        public async Task AddResultSegmentAsync(ResultSegmentModel resultSegment)
        {
            await _context.ResultSegments.AddAsync(resultSegment);
            //await _context.SaveChangesAsync();
        }

        public async Task AddResultSubCategoryAsync(ResultSubCategoryModel resultSubCategory)
        {
            await _context.ResultSubCategories.AddAsync(resultSubCategory);
            //await _context.SaveChangesAsync();
        }
        public async Task AddResultQuestionAsync(ResultQuestionModel resultQuestion)
        {
            await _context.ResultQuestions.AddAsync(resultQuestion);
            //await _context.SaveChangesAsync();
        }

        public async Task UpdateResultAsync(ResultModel result)
        {
            _context.Entry(result).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task<ResultSubCategoryModel?> GetSubCatByUserId(string userId, int subCatId)
        {
            return await _context.ResultSubCategories.Include(rsc => rsc.ResultQuestions).FirstOrDefaultAsync(rsc => rsc.SubCategoryModelId == subCatId && rsc.ApplicationUserId == userId);

        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
