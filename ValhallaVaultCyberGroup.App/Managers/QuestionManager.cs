using ValhallaVaultCyberGroup.Data.Models.Domain;
using ValhallaVaultCyberGroup.Data.Repositories;

namespace ValhallaVaultCyberGroup.App.Managers
{
    public class QuestionManager
    {

        private readonly IQuestionsRepo _repo;

        public QuestionManager(IQuestionsRepo repo)
        {
            _repo = repo;
        }

        //Hämta alla kategorier

        public async Task<List<CategoryModel?>> GetAllCategoriesAsync()
        {
            return await _repo.GetAllAsync();
        }


        //Hämta en kategori med namn

        public async Task<CategoryModel?> GetCategoryAsync(string name)
        {
            return await _repo.GetCategoryAsync(name);
        }

        public async Task<CategoryModel?> GetCategoryAsync(int id)
        {
            return await _repo.GetCategoryAsync(id);
        }

        //Ta bort en kategori
        public void RemoveCategory(CategoryModel modelToRemove)
        {
            _repo.RemoveCategoryAsync(modelToRemove);
            _repo.SaveChangesAsync();

        }

        //Lägg till en ny kategori
        public async Task<CategoryModel> AddCategoryAsync(string name)
        {
            CategoryModel model = new CategoryModel();

            model.Name = name;
            var addedModel = await _repo.AddCategoryAsync(model);
            await _repo.SaveChangesAsync();
            return addedModel;

        }

        //Uppdatera kategori
        public async Task<CategoryModel?> UpdateCategoryAsync(int id, string name)
        {

            var categoryToUpdate = await _repo.GetCategoryAsync(id);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = name;

                await _repo.UpdateCategoryAsync(categoryToUpdate);
                await _repo.SaveChangesAsync();
            }


            return categoryToUpdate;

        }


        //Hämta alla frågor

        public async Task<List<QuestionModel?>> GetAllQuestionsAsync()
        {
            return await _repo.GetAllQuestionsAsync();
        }

        //Hämta en fråga med Id

        public async Task<QuestionModel?> GetQuestionAsync(int id)
        {
            return await _repo.GetQuestionAsync(id);
        }



        //Ta bort en fråga

        public async void RemoveQuestionAsync(QuestionModel question)
        {
            _repo.RemoveQuestionAsync(question);
            await _repo.SaveChangesAsync();
        }


        //Lägg till en ny fråga
        public async Task<QuestionModel> AddQuestionAsync(string text, int id)
        {
            QuestionModel model = new QuestionModel();
            model.SubCategoryId = id;
            model.Text = text;
            var addedModel = await _repo.AddQuestionAsync(model);
            await _repo.SaveChangesAsync();
            return addedModel;
        }


        //Uppdatera en fråga

        public async Task<QuestionModel?> UpdateQuestionAsync(int id, string text, int subCategoryId)
        {
            var questionToUpdate = await _repo.GetQuestionAsync(id);

            if (questionToUpdate != null)
            {
                questionToUpdate.SubCategoryId = subCategoryId;
                questionToUpdate.Text = text;
                await _repo.UpdateQuestionAsync(questionToUpdate);
                await _repo.SaveChangesAsync();
            }

            return questionToUpdate;


        }


        //Hämta alla Sub-kategorier
        public async Task<List<SubCategoryModel?>> GetAllSubCategoriesAsync()
        {
            return await _repo.GetAllSubCategoriesAsync();
        }

        //Hämta en sub kategori med id

        public async Task<SubCategoryModel?> GetSubCategoryAsync(int id)
        {
            return await _repo.GetSubCategoryAsync(id);
        }

        //Hämta en sub kategori med name

        public async Task<SubCategoryModel?> GetSubCategoryAsync(string name)
        {
            return await _repo.GetSubCategoryAsync(name);
        }

        public void RemoveSubCategoryAsync(SubCategoryModel model)
        {
            _repo.RemoveSubCategoryAsync(model);
            _repo.SaveChangesAsync();
        }


        public async Task<SubCategoryModel?> UpdateSubCategoryAsync(int id, string name, int segmentId)
        {
            var subCategoryToUpdate = await _repo.GetSubCategoryAsync(id);

            if (subCategoryToUpdate != null)
            {
                subCategoryToUpdate.SegmentId = segmentId;
                subCategoryToUpdate.Name = name;
                await _repo.UpdateSubCategoryAsync(subCategoryToUpdate);
                await _repo.SaveChangesAsync();

            }

            return subCategoryToUpdate;

        }

        //Lägg till en subcategory
        public async Task<SubCategoryModel> AddSubCategoryAsync(string name, int id)
        {
            SubCategoryModel model = new SubCategoryModel();
            model.SegmentId = id;
            model.Name = name;
            var addedModel = await _repo.AddSubCategoryAsync(model);
            await _repo.SaveChangesAsync();
            return addedModel;
        }


        //Hämta alla responses
        public async Task<List<ResponseModel>> GetAllResponsesAsync()
        {
            return await _repo.GetAllResponsesAsync();
        }

        //Hämta en response med id

        public async Task<ResponseModel?> GetResponseAsync(int id)
        {
            return await _repo.GetResponseAsync(id);
        }

        //Hämta en response med text

        //public async Task<ResponseModel?> GetResponseAsync(string text)
        //{
        //    return await _repo.GetResponseAsync(text);
        //}

        //Remove

        public void RemoveResponseAsync(ResponseModel response)
        {
            _repo.RemoveResponseAsync(response);
            _repo.SaveChangesAsync();
        }

        //Uppdate

        public async Task<ResponseModel?> UpdateResponseAsync(int id, string text, int questionId)
        {
            var responseToUpdate = await _repo.GetResponseAsync(id);
            if (responseToUpdate != null)

            {
               responseToUpdate.QuestionId = questionId;
                responseToUpdate.Text = text;
                await _repo.UpdateResponseAsync(responseToUpdate);
                await _repo.SaveChangesAsync();

            }

            return responseToUpdate;
        }


        //Add

        public async Task<ResponseModel> AddResponseAsync(string text, int id)
        {
            ResponseModel model = new ResponseModel();
            model.QuestionId = id;
            model.Text = text;
            var addedModel = await _repo.AddResponseAsync(model);
            await _repo.SaveChangesAsync();
            return addedModel;
        }

        //Hämta alla segments

        public async Task<List<SegmentModel>> GetSegmentAsync()
        {
            return await _repo.GetAllSegmentsAsync();
        }

        //Hämta segment med id

        public async Task<SegmentModel?> GetSegmentAsync(int id)
        {
            return await _repo.GetSegmentAsync(id);
        }


        //Hämta segment med id

        public async Task<SegmentModel?> GetSegmentAsync(string name)
        {
            return await _repo.GetSegmentAsync(name);
        }

        //Remove

        public void RemoveSegmentAsync(SegmentModel segment)
        {
            _repo.RemoveSegmentAsync(segment);
            _repo.SaveChangesAsync();
        }


        //update

        public async Task<SegmentModel?> UpdateSegmentAsync(int id, string name, int categoryId)
        {
            var segmentToUpdate = await _repo.GetSegmentAsync(id);
            if (segmentToUpdate != null)
            {
                segmentToUpdate.CategoriesId = categoryId;
                segmentToUpdate.Name = name;
                await _repo.UpdateSegmentAsync(segmentToUpdate);
                await _repo.SaveChangesAsync();
            }

            return segmentToUpdate;
        }


        //Add

        public async Task<SegmentModel> AddSegmentAsync(string name, int id)
        {
            SegmentModel model = new SegmentModel();
            model.CategoriesId = id;
            model.Name = name;
            var addedModel = await _repo.AddSegmentAsync(model);
            await _repo.SaveChangesAsync();
            return addedModel;
        }



    }

}

