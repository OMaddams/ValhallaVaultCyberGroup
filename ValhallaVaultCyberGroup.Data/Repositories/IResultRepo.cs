
using ValhallaVaultCyberGroup.Data.Models.Result;

namespace ValhallaVaultCyberGroup.Data.Repositories

{
    public interface IResultRepo
    {
        //bool CheckSubcategoryProgress(string userId, int subCategoryId);

        bool CheckSubcategoryCompletion(string userId, int subCategoryId);


        //Task<ResultModel?> GetResultByIdAsync(int resultId);
        Task AddResultAsync(ResultModel result);
        Task UpdateResultAsync(ResultModel result);

        Task AddResultSegmentAsync(ResultSegmentModel resultSegment);

        Task AddResultSubCategoryAsync(ResultSubCategoryModel resultSubCategory);
        Task AddResultQuestionAsync(ResultQuestionModel resultQuestion);
        Task<ResultSubCategoryModel?> GetSubCatByUserId(string userId, int subCatId);

        Task SaveChanges();
    }
}
