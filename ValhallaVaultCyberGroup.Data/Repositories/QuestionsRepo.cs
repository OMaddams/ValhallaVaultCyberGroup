﻿using Microsoft.EntityFrameworkCore;
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

        public Task<CategoryModel> AddCategoryAsync(CategoryModel categoryToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionModel> AddQuestionAsync(QuestionModel questionToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<SegmentModel> AddSegmentAsync(SegmentModel segmentToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryModel> AddSubCategoryAsync(SubCategoryModel subCategoryToAdd)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryModel>> GetAllAsync()
        {
            return await context.CategoryModels.Include(c => c.Segments).ThenInclude(s => s.SubCategories).ThenInclude(s => s.Questions).ThenInclude(q => q.Responses).ToListAsync();
        }

        public Task<List<QuestionModel>> GetAllQuestionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<SegmentModel>> GetAllSegmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<SubCategoryModel>> GetAllSubCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryModel?> GetCategoryAsync(int id)
        {
            return await context.CategoryModels.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<CategoryModel?> GetCategoryAsync(string name)
        {
            return await context.CategoryModels.FirstOrDefaultAsync(c => c.Name == name);
        }

        public Task<QuestionModel> GetQuestionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionModel> GetQuestionAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<SegmentModel> GetSegmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SegmentModel> GetSegmentAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryModel> GetSubCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryModel> GetSubCategoryAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveCategoryAsync(CategoryModel modelToRemove)
        {
            context.CategoryModels.Remove(modelToRemove);
            await context.SaveChangesAsync();
        }

        public Task RemoveQuestionAsync(QuestionModel questionToRemove)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSegmentAsync(SegmentModel segmentToRemove)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSubCategoryAsync(SubCategoryModel subCategoryToRemove)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryModel> UpdateCategoryAsync(CategoryModel categoryToUpdate)
        {
            var currentModel = await GetCategoryAsync(categoryToUpdate.Id);
            currentModel = categoryToUpdate;
            await context.SaveChangesAsync();
            return currentModel;
        }

        public Task<QuestionModel> UpdateQuestionAsync(QuestionModel questionToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<SegmentModel> UpdateSegmentAsync(SegmentModel segmentToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryModel> UpdateSubCategoryAsync(SubCategoryModel subCategoryToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
