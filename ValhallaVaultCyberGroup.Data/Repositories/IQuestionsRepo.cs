using ValhallaVaultCyberGroup.Data.Models.Domain;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public interface IQuestionsRepo
    {
        public Task<List<CategoryModel?>> GetAllAsync();
        public Task<CategoryModel?> GetCategoryAsync(int id);
        public Task<CategoryModel?> GetCategoryAsync(string id);
        public void RemoveCategoryAsync(CategoryModel modelToRemove);
        public Task<CategoryModel> AddCategoryAsync(CategoryModel categoryToAdd);
        public Task<CategoryModel> UpdateCategoryAsync(CategoryModel categoryToUpdate);


        public Task<List<SegmentModel>> GetAllSegmentsAsync();
        public Task<SegmentModel?> GetSegmentAsync(int id);
        public Task<SegmentModel?> GetSegmentAsync(string name);
        public Task<SegmentModel> AddSegmentAsync(SegmentModel segmentToAdd);
        public Task<SegmentModel> UpdateSegmentAsync(SegmentModel segmentToUpdate);
        public void RemoveSegmentAsync(SegmentModel segmentToRemove);

        public Task<List<SubCategoryModel?>> GetAllSubCategoriesAsync();
        public Task<SubCategoryModel?> GetSubCategoryAsync(int id);
        public Task<SubCategoryModel?> GetSubCategoryAsync(string name);
        public Task<SubCategoryModel> AddSubCategoryAsync(SubCategoryModel subCategoryToAdd);
        public Task<SubCategoryModel> UpdateSubCategoryAsync(SubCategoryModel subCategoryToUpdate);
        public void RemoveSubCategoryAsync(SubCategoryModel subCategoryToRemove);

        public Task<List<QuestionModel?>> GetAllQuestionsAsync();
        public Task<QuestionModel?> GetQuestionAsync(int id);
        public Task<QuestionModel?> GetQuestionAsync(string name);
        public Task<QuestionModel> AddQuestionAsync(QuestionModel questionToAdd);
        public Task<QuestionModel> UpdateQuestionAsync(QuestionModel questionToUpdate);
        public void RemoveQuestionAsync(QuestionModel questionToRemove);

        public Task<List<ResponseModel>> GetAllResponsesAsync();
        public Task<ResponseModel?> GetResponseAsync(int id);
        public Task<ResponseModel?> GetResponseAsync(QuestionModel question);
        public Task<ResponseModel> AddResponseAsync(ResponseModel responseToAdd);
        public Task<ResponseModel?> UpdateResponseAsync(ResponseModel responseToUpdate);
        public void RemoveResponseAsync(ResponseModel responseToRemove);

        public Task SaveChangesAsync();
    }
}
