
﻿using ValhallaVaultCyberGroup.Data.Models.Result;

namespace ValhallaVaultCyberGroup.Data.Repositories

{
    public interface IResultRepo
    {
        bool CheckSubcategoryProgress(string userId, int subCategoryId);

        Task<ResultModel?> GetResultByIdAsync(int resultId);
        Task AddResultAsync(ResultModel result);
        Task UpdateResultAsync(ResultModel result);

    }
}
