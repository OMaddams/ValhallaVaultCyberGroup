
﻿using ValhallaVaultCyberGroup.Data.Models.Result;
using ValhallaVaultCyberGroup.Data.Repositories;


namespace ValhallaVaultCyberGroup.App.Managers
{
    public class ResultManager
    {
        private readonly IResultRepo _resultRepo;

        public ResultManager(IResultRepo resultRepo)
        {
            _resultRepo = resultRepo;
        }

        public bool CheckSubcategoryProgress(string userId, int subCategoryId)
        {
            return _resultRepo.CheckSubcategoryProgress(userId, subCategoryId);
        }


        public async Task<bool> CheckPreviousSubcategoriesCompleted(string userId, int currentSubCategoryId)
        {

            for (int i = 1; i < currentSubCategoryId; i++)
            {
                bool isCompleted = _resultRepo.CheckSubcategoryProgress(userId, i);
                if (!isCompleted)
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<ResultModel?> GetResultByIdAsync(int resultId)
        {
            return await _resultRepo.GetResultByIdAsync(resultId);
        }

        public async Task AddResultAsync(ResultModel result)
        {
            await _resultRepo.AddResultAsync(result);
        }

        public async Task UpdateResultAsync(ResultModel result)
        {
            await _resultRepo.UpdateResultAsync(result);
        }


    }
}
