
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

        public async Task<ResultModel?> GetByUserIdAsync(string userId)
        {
            return await _context.Results.Include(r => r.ResultSegments).ThenInclude(rs => rs.ResultSubCategories).FirstOrDefaultAsync(r => r.username == userId);
        }

        //public bool CheckSubcategoryProgress(string userId, int subCategoryId)
        //{
        //    return _context.ResultSubCategories
        //            .Include(rsc => rsc.ResultQuestions)
        //            .Any(rsc => rsc.ApplicationUserId == userId && rsc.SubCategoryModelId == subCategoryId &&
        //                        rsc.ResultQuestions.Any(q => q.IsCorrect) &&
        //                        rsc.ResultQuestions.Count * 100 / rsc.ResultQuestions.Count(q => q.IsCorrect) >= 80);
        //}

        public bool CheckSubcategoryCompletion(string userId, int subCategoryId)
        {
            var subcategory = _context.ResultSubCategories
                .Include(rsc => rsc.ResultQuestions)
                .FirstOrDefault(rsc => rsc.username == userId && rsc.SubCategoryModelId == subCategoryId);

            if (subcategory != null)
            {
                int totalQuestions = subcategory.ResultQuestions.Count;
                int correctAnswers = subcategory.ResultQuestions.Count(q => q.IsCorrect);
                bool isCompleted = totalQuestions > 0 && correctAnswers * 100 / totalQuestions >= 80;

                if (isCompleted && !subcategory.IsCompleted)
                {
                    subcategory.IsCompleted = true;
                    _context.SaveChanges();
                }

                return isCompleted;
            }

            return false;
        }

        public bool CheckSegmentCompletion(string userId, int segmentId)
        {
            var segment = _context.ResultSegments
                .Include(rs => rs.ResultSubCategories)
                .ThenInclude(rsc => rsc.ResultQuestions)
                .FirstOrDefault(rs => rs.ResultModel.username == userId && rs.Id == segmentId);

            if (segment != null)
            {
                bool allSubCategoriesCompleted = segment.ResultSubCategories.All(rsc => rsc.IsCompleted);

                if (allSubCategoriesCompleted && !segment.IsCompleted)
                {
                    segment.IsCompleted = true;
                    _context.SaveChanges();
                }

                return allSubCategoriesCompleted;
            }

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
            await _context.SaveChangesAsync();
        }

        public async Task AddResultSegmentAsync(ResultSegmentModel resultSegment)
        {
            await _context.ResultSegments.AddAsync(resultSegment);
            await _context.SaveChangesAsync();
        }

        public async Task AddResultSubCategoryAsync(ResultSubCategoryModel resultSubCategory)
        {
            await _context.ResultSubCategories.AddAsync(resultSubCategory);
            await _context.SaveChangesAsync();
        }
        public async Task AddResultQuestionAsync(ResultQuestionModel resultQuestion)
        {
            await _context.ResultQuestions.AddAsync(resultQuestion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateResultAsync(ResultModel result)
        {
            _context.Entry(result).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task<ResultSubCategoryModel?> GetSubCatByUserId(string userId, int subCatId)
        {
            return await _context.ResultSubCategories.Include(rsc => rsc.ResultQuestions).FirstOrDefaultAsync(rsc => rsc.SubCategoryModelId == subCatId && rsc.username == userId);

        }

        public async Task RemoveAllSegment(int segmentId)
        {
            await _context.ResultSegments.Where(s => s.SegmentModelId == segmentId).ExecuteDeleteAsync();
        }
        public async Task RemoveAllSubcat(int subcatId)
        {
            await _context.ResultSubCategories.Where(s => s.SubCategoryModelId == subcatId).ExecuteDeleteAsync();
        }
        public async Task RemoveAllQuestion(int questionId)
        {
            await _context.ResultQuestions.Where(q => q.QuestionModelId == questionId).ExecuteDeleteAsync();
        }

        public async Task<List<ResultModel>> GetAllResult()
        {
            return await _context.Results.Include(r => r.ResultSegments).ThenInclude(rs => rs.ResultSubCategories).ToListAsync();
        }

        public async Task<List<ResultSubCategoryModel>> GetAllSubcategoriesBySubcatId(int subcategoryId)
        {
            return await _context.ResultSubCategories.Where(s => s.SubCategoryModelId == subcategoryId).ToListAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
