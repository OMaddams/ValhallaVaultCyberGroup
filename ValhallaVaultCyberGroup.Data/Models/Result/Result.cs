using ValhallaVaultCyberGroup.Ui.Data;

namespace ValhallaVaultCyberGroup.Data.Models.Result
{
    public class ResultModel
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public string username { get; set; } = null!;
        public string ApplicationUserId { get; set; }
        public List<ResultSegmentModel> ResultSegments { get; set; }
    }


    public class ResultSegmentModel
    {
        public int Id { get; set; }
        public int ResultModelId { get; set; }
        public ResultModel ResultModel { get; set; } = null!;
        public int SegmentModelId { get; set; }
        public List<ResultSubCategoryModel> ResultSubCategories { get; set; }
        public bool IsCompleted { get; set; }
    }
    public class ResultSubCategoryModel
    {
        public int Id { get; set; }
        public int ResultSegmentModelId { get; set; }
        public string username { get; set; } = null!;
        public ResultSegmentModel ResultSegmentModel { get; set; }
        public List<ResultQuestionModel> ResultQuestions { get; set; }

        public int SubCategoryModelId { get; set; }
        public bool IsCompleted { get; set; }
    }


    public class ResultQuestionModel
    {
        public int Id { get; set; }
        public int QuestionModelId { get; set; }
        public int ResultSubCategoryModelId { get; set; }
        public ResultSubCategoryModel ResultSubCategoryModel { get; set; }
        public bool IsCorrect { get; set; }

    }
}

