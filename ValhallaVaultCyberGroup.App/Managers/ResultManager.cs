
using ValhallaVaultCyberGroup.Data.Models.Domain;
using ValhallaVaultCyberGroup.Data.Models.Result;
using ValhallaVaultCyberGroup.Data.Repositories;


namespace ValhallaVaultCyberGroup.App.Managers
{
    public class ResultManager
    {
        private readonly IResultRepo _resultRepo;
        private readonly QuestionManager questionManager;
        private List<CategoryModel?>? CategoriesTree;
        public ResultManager(IResultRepo resultRepo, QuestionManager questionManager)
        {
            _resultRepo = resultRepo;
            this.questionManager = questionManager;



        }

        public async Task<ResultModel?> GetByUserIdAsync(string userId)
        {
            return await _resultRepo.GetByUserIdAsync(userId);
        }


        //public bool CheckSubcategoryProgress(string userId, int subCategoryId)
        //{
        //    return _resultRepo.CheckSubcategoryProgress(userId, subCategoryId);
        //}

        public bool CheckSubcategoryCompletion(string userId, int subCategoryId)
        {
            return _resultRepo.CheckSubcategoryCompletion(userId, subCategoryId);
        }

        public bool CheckSegmentCompletion(string userId, int segmentId)
        {
            return _resultRepo.CheckSegmentCompletion(userId, segmentId);
        }

        //public async Task<bool> CheckPreviousSubcategoriesCompleted(string userId, int currentSubCategoryId)
        //{

        //    for (int i = 1; i < currentSubCategoryId; i++)
        //    {
        //        bool isCompleted = _resultRepo.CheckSubcategoryCompletion(userId, i);
        //        if (!isCompleted)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public async Task<ResultModel?> GetResultByIdAsync(int resultId)
        //{
        //    return await _resultRepo.GetResultByIdAsync(resultId);
        //}

        public async Task AddResultAsync(ResultModel result)
        {
            await _resultRepo.AddResultAsync(result);
        }

        public async Task UpdateResultAsync(ResultModel result)
        {
            await _resultRepo.UpdateResultAsync(result);
        }

        public async Task CreateUserResults(string applicationUserId, string userName)
        {
            CategoriesTree = await questionManager.GetAllCategoriesAsync();


            ResultModel resultModelToAdd = new()
            {
                ApplicationUserId = applicationUserId,
                username = userName
            };
            await AddResultAsync(resultModelToAdd);

            foreach (var Category in CategoriesTree)
            {

                foreach (var segment in Category.Segments)
                {
                    ResultSegmentModel resultSegToAdd = new()
                    {
                        ResultModelId = resultModelToAdd.Id,
                        SegmentModelId = segment.Id,
                        IsCompleted = false,

                    };

                    await _resultRepo.AddResultSegmentAsync(resultSegToAdd);

                    foreach (var subcat in segment.SubCategories)
                    {
                        ResultSubCategoryModel resultSubCategory = new()
                        {
                            ResultSegmentModelId = resultSegToAdd.Id,
                            IsCompleted = false,
                            username = userName,
                            SubCategoryModelId = subcat.Id,
                        };

                        await _resultRepo.AddResultSubCategoryAsync(resultSubCategory);


                        foreach (var question in subcat.Questions)
                        {
                            ResultQuestionModel resultQuestionToAdd = new()
                            {
                                ResultSubCategoryModelId = resultSubCategory.Id,
                                QuestionModelId = question.Id,
                                IsCorrect = false,
                            };

                            await _resultRepo.AddResultQuestionAsync(resultQuestionToAdd);
                            await _resultRepo.SaveChanges();
                        }

                    }
                }

            }

        }

        public async Task<ResultSubCategoryModel?> GetUserSubcategory(string userId, int subCategoryId)
        {
            return await _resultRepo.GetSubCatByUserId(userId, subCategoryId);
        }

        /// <summary>
        /// Receives the id of the user whose result to change, the subcategory id with the results you wish to change, and a list of ResultQuestionModels that contain, QuestionModelId and IsCorrect 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="subcategoryId"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public async Task SubmitUserSubCategoryResults(string userId, int subcategoryId, List<ResultQuestionModel> results)
        {
            var userSubcat = await _resultRepo.GetSubCatByUserId(userId, subcategoryId);

            if (userSubcat == null)
            {
                return;
            }
            results = results.OrderBy(r => r.QuestionModelId).ToList();
            userSubcat.ResultQuestions = userSubcat.ResultQuestions.OrderBy(r => r.QuestionModelId).ToList();
            for (int i = 0; i < results.Count; i++)
            {
                userSubcat.ResultQuestions[i].IsCorrect = results[i].IsCorrect;
            }

            await _resultRepo.SaveChanges();


        }

        public async Task RemoveSegment(int segmentId)
        {
            await _resultRepo.RemoveAllSegment(segmentId);
            await _resultRepo.SaveChanges();
        }

        public async Task RemoveSubCat(int subcatId)
        {
            await _resultRepo.RemoveAllSubcat(subcatId);
            await _resultRepo.SaveChanges();
        }

        public async Task RemoveQuestion(int questionId)
        {
            await _resultRepo.RemoveAllQuestion(questionId);
            await _resultRepo.SaveChanges();
        }

        public async Task AddSegmentToUsers(SegmentModel segmentToAdd)
        {
            List<ResultModel> Results = await _resultRepo.GetAllResult();

            ResultSegmentModel resultSegmentModelToAdd = new ResultSegmentModel()
            {
                SegmentModelId = segmentToAdd.Id,
                IsCompleted = false,

            };

            foreach (var result in Results)
            {
                resultSegmentModelToAdd.ResultModelId = result.Id;
                await _resultRepo.AddResultSegmentAsync(resultSegmentModelToAdd);
            }
            await _resultRepo.SaveChanges();
        }

        public async Task AddSubcatsToUsers(SubCategoryModel subcatToAdd)
        {
            List<ResultModel> Results = await _resultRepo.GetAllResult();

            ResultSubCategoryModel resultSubCatModelToAdd = new ResultSubCategoryModel()
            {
                SubCategoryModelId = subcatToAdd.Id,
                IsCompleted = false,


            };

            foreach (var result in Results)
            {
                resultSubCatModelToAdd.username = result.username;
                resultSubCatModelToAdd.ResultSegmentModelId = result.ResultSegments.FirstOrDefault(rs => rs.SegmentModelId == subcatToAdd.SegmentId).Id;
                await _resultRepo.AddResultSubCategoryAsync(resultSubCatModelToAdd);
            }
            await _resultRepo.SaveChanges();
        }

        public async Task AddQuestionToUser(QuestionModel questionToAdd)
        {
            List<ResultModel> Results = await _resultRepo.GetAllResult();
            List<ResultSubCategoryModel> subcatsToAddTo = await _resultRepo.GetAllSubcategoriesBySubcatId(questionToAdd.SubCategoryId);

            ResultQuestionModel resultQuestionToAdd = new ResultQuestionModel()
            {
                IsCorrect = false,
                QuestionModelId = questionToAdd.Id,
            };

            foreach (var subcat in subcatsToAddTo)
            {
                resultQuestionToAdd.ResultSubCategoryModelId = subcat.Id;
                await _resultRepo.AddResultQuestionAsync(resultQuestionToAdd);
            }
            await _resultRepo.SaveChanges();
        }

        public async Task UpdateSubcats(SubCategoryModel subCategory)
        {
            await _resultRepo.UpdateAllSubCats(subCategory);
        }
        public async Task UpdateQuestions(QuestionModel questionModel)
        {
            await _resultRepo.UpdateAllQuestions(questionModel);
        }

    }
}
