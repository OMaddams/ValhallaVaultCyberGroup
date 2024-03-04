using ValhallaVaultCyberGroup.Data.Models.Domain;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public interface IQuestionsRepo
    {
        public List<CategoryModel> GetAllAsync();
        public CategoryModel GetById(int id);
        public CategoryModel GetByName(string id);
        public void RemoveCategory(CategoryModel modelToRemove);
        public CategoryModel AddCategory(CategoryModel categoryToAdd);
        public CategoryModel UpdateCategory(CategoryModel categoryToUpdate);


        public List<SegmentModel> GetAllSegments();
        public SegmentModel GetSegment(int id);
        public SegmentModel GetSegment(string name);
        public SegmentModel AddSegment(SegmentModel segmentToAdd);
        public SegmentModel UpdateSegment(SegmentModel segmentToUpdate);
        public void RemoveSegment(SegmentModel segmentToRemove);

        public List<SubCategoryModel> GetAllSubCategories();
        public SubCategoryModel GetSubCategory(int id);
        public SubCategoryModel GetSubCategory(string name);
        public SubCategoryModel AddSubCategory(SubCategoryModel subCategoryToAdd);
        public SubCategoryModel UpdateSubCategory(SubCategoryModel subCategoryToUpdate);
        public void RemoveSubCategory(SubCategoryModel subCategoryToRemove);

        public List<QuestionModel> GetAllQuestions();
        public QuestionModel GetQuestion(int id);
        public QuestionModel GetQuestion(string name);
        public QuestionModel AddQuestion(QuestionModel questionToAdd);
        public QuestionModel UpdateQuestion(QuestionModel questionToUpdate);
        public void RemoveQuestion(QuestionModel questionToRemove);



    }
}
