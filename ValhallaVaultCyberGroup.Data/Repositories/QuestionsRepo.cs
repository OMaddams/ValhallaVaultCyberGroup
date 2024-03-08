using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.Data.Data;
using ValhallaVaultCyberGroup.Data.Models.Domain;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public class QuestionsRepo : IQuestionsRepo
    {
        private readonly QuizDbContext context;

        public QuestionsRepo(QuizDbContext context)
        {
            this.context = context;
        }


        public async Task<CategoryModel> AddCategoryAsync(CategoryModel categoryToAdd)
        {
            await context.CategoryModels.AddAsync(categoryToAdd);
            return categoryToAdd;
        }

        public async Task<QuestionModel> AddQuestionAsync(QuestionModel questionToAdd)
        {
            await context.QuestionModels.AddAsync(questionToAdd);
            return questionToAdd;
        }

        public async Task<SegmentModel> AddSegmentAsync(SegmentModel segmentToAdd)
        {
            await context.SegmentModels.AddAsync(segmentToAdd);
            return segmentToAdd;
        }

        public async Task<SubCategoryModel> AddSubCategoryAsync(SubCategoryModel subCategoryToAdd)
        {
            await context.SubCategoryModels.AddAsync(subCategoryToAdd);
            return subCategoryToAdd;
        }
        /// <summary>
        /// Gets all Categories with all the includes all the way down the tree
        /// </summary>
        /// <returns></returns>
        public async Task<List<CategoryModel>> GetAllAsync()
        {
            return await context.CategoryModels.Include(c => c.Segments).ThenInclude(s => s.SubCategories).ThenInclude(s => s.Questions).ThenInclude(q => q.Responses).ToListAsync();
        }

        public async Task<List<QuestionModel>> GetAllQuestionsAsync()
        {
            return await context.QuestionModels.ToListAsync();
        }

        public Task<List<SegmentModel>> GetAllSegmentsAsync()
        {
            return context.SegmentModels.ToListAsync();
        }

        public Task<List<SubCategoryModel>> GetAllSubCategoriesAsync()
        {
            return context.SubCategoryModels.ToListAsync();
        }
        /// <summary>
        /// Gets the Category by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryModel?> GetCategoryAsync(int id)
        {
            return await context.CategoryModels.FirstOrDefaultAsync(c => c.Id == id);
        }
        /// <summary>
        /// Gets the Category by name 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<CategoryModel?> GetCategoryAsync(string name)
        {
            return await context.CategoryModels.FirstOrDefaultAsync(c => c.Name == name);
        }

        /// <summary>
        /// Gets the Question by Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<QuestionModel?> GetQuestionAsync(int id)
        {
            return await context.QuestionModels.FirstOrDefaultAsync(q => q.Id == id);
        }

        /// <summary>
        /// Gets the Segment by Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SegmentModel?> GetSegmentAsync(int id)
        {
            return await context.SegmentModels.FirstOrDefaultAsync(s => s.Id == id);
        }
        /// <summary>
        /// Gets the Segment by name 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SegmentModel?> GetSegmentAsync(string name)
        {
            return await context.SegmentModels.FirstOrDefaultAsync(s => s.Name == name);
        }
        /// <summary>
        /// Gets the Sub category by Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<SubCategoryModel?> GetSubCategoryAsync(int id)
        {
            return await context.SubCategoryModels.Include(s=>s.Questions).ThenInclude(q=>q.Responses).FirstOrDefaultAsync(s => s.Id == id);
        }
        /// <summary>
        /// Gets the Sub category by name 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SubCategoryModel?> GetSubCategoryAsync(string name)
        {
            return await context.SubCategoryModels.FirstOrDefaultAsync(s => s.Name == name);
        }

        public void RemoveCategoryAsync(CategoryModel modelToRemove)
        {
            context.CategoryModels.Remove(modelToRemove);

        }

        public void RemoveQuestionAsync(QuestionModel questionToRemove)
        {

            context.QuestionModels.Remove(questionToRemove);
        }

        public void RemoveSegmentAsync(SegmentModel segmentToRemove)
        {
            context.SegmentModels.Remove(segmentToRemove);
        }

        public void RemoveSubCategoryAsync(SubCategoryModel subCategoryToRemove)
        {
            context.SubCategoryModels.Remove(subCategoryToRemove);
        }
        /// <summary>
        /// Takes a updated CategoryModel, uses it to update the existing categorymodel, returns updated model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryModel> UpdateCategoryAsync(CategoryModel categoryToUpdate)
        {
            var currentModel = await GetCategoryAsync(categoryToUpdate.Id);
            currentModel = categoryToUpdate;
            return currentModel;
        }
        /// <summary>
        /// Takes a updated Question, uses it to update the existing questionmodel, returns updated model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<QuestionModel> UpdateQuestionAsync(QuestionModel questionToUpdate)
        {
            var currentQuestion = await GetQuestionAsync(questionToUpdate.Id);
            currentQuestion = questionToUpdate;
            return currentQuestion;
        }
        /// <summary>
        /// Takes a updated SegmentModel, uses it to update the existing segment, returns updated model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SegmentModel> UpdateSegmentAsync(SegmentModel segmentToUpdate)
        {
            var currentSegment = await GetSegmentAsync(segmentToUpdate.Id);
            currentSegment = segmentToUpdate;
            return currentSegment;
        }
        /// <summary>
        /// Takes a updated SegmentModel, uses it to update the existing segmentmodel, returns updated model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SubCategoryModel> UpdateSubCategoryAsync(SubCategoryModel subCategoryToUpdate)
        {
            var currentSubCategory = await GetSubCategoryAsync(subCategoryToUpdate.Id);
            currentSubCategory = subCategoryToUpdate;
            return currentSubCategory;
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task<List<ResponseModel>> GetAllResponsesAsync()
        {
            return await context.ResponseModels.ToListAsync();
        }
        /// <summary>
        /// Gets the response by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResponseModel?> GetResponseAsync(int id)
        {
            return await context.ResponseModels.FirstOrDefaultAsync(r => r.Id == id);
        }
        /// <summary>
        /// Gets the response by QuestionModel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<ResponseModel?> GetResponseAsync(QuestionModel question)
        {
            return await context.ResponseModels.FirstOrDefaultAsync(r => r.QuestionId == question.Id);
        }

        public async Task<ResponseModel> AddResponseAsync(ResponseModel responseToAdd)
        {
            await context.ResponseModels.AddAsync(responseToAdd);
            return responseToAdd;
        }
        /// <summary>
        /// Takes a updated ResponseModel, uses it to update the existing responsemodel, returns updated model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResponseModel?> UpdateResponseAsync(ResponseModel responseToUpdate)
        {
            var currentResponse = await GetResponseAsync(responseToUpdate.Id);
            currentResponse = responseToUpdate;
            return currentResponse;
        }

        public void RemoveResponseAsync(ResponseModel responseToRemove)
        {
            context.ResponseModels.Remove(responseToRemove);
        }
    }
}
