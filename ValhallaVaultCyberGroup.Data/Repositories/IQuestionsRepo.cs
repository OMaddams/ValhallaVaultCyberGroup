using ValhallaVaultCyberGroup.Data.Models.Domain;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public interface IQuestionsRepo
    {
        public Task<List<CategoryModel>> GetAllAsync();
        public Task<CategoryModel> GetByIdAsync(int id);
        public Task<CategoryModel> GetByNameAsync(string id);
        public Task RemoveCategoryAsync(CategoryModel modelToRemove);
        public Task<CategoryModel> AddCategoryAsync(CategoryModel categoryToAdd);
        public Task<CategoryModel> UpdateCategoryAsync(CategoryModel categoryToUpdate);


        public Task<List<SegmentModel>> GetAllSegmentsAsync();
        public Task<SegmentModel> GetSegmentAsync(int id);
        public Task<SegmentModel> GetSegmentAsync(string name);
        public Task<SegmentModel> AddSegmentAsync(SegmentModel segmentToAdd);
        public Task<SegmentModel> UpdateSegmentAsync(SegmentModel segmentToUpdate);
        public Task RemoveSegmentAsync(SegmentModel segmentToRemove);

        public Task<List<SubCategoryModel>> GetAllSubCategoriesAsync();
        public Task<SubCategoryModel> GetSubCategoryAsync(int id);
        public Task<SubCategoryModel> GetSubCategoryAsync(string name);
        public Task<SubCategoryModel> AddSubCategoryAsync(SubCategoryModel subCategoryToAdd);
        public Task<SubCategoryModel> UpdateSubCategoryAsync(SubCategoryModel subCategoryToUpdate);
        public Task RemoveSubCategoryAsync(SubCategoryModel subCategoryToRemove);

        public Task<List<QuestionModel>> GetAllQuestionsAsync();
        public Task<QuestionModel> GetQuestionAsync(int id);
        public Task<QuestionModel> GetQuestionAsync(string name);
        public Task<QuestionModel> AddQuestionAsync(QuestionModel questionToAdd);
        public Task<QuestionModel> UpdateQuestionAsync(QuestionModel questionToUpdate);
        public Task RemoveQuestionAsync(QuestionModel questionToRemove);



    }
}
