using ValhallaVaultCyberGroup.Ui.Data;

namespace ValhallaVaultCyberGroup.Data.Models.Result
{
    public class ResultModel
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public string ApplicationUserId { get; set; }
        public List<ResultCategoryModel> ResultsCategories { get; set; }
    }

    public class ResultCategoryModel
    {
        public int Id { get; set; }
        public int ResultId { get; set; }
        public List<ResultSegmentModel> ResultSegments { get; set; }
        public bool IsCompleted { get; set; }

    public class ResultSegmentModel
    {
        public int Id { get; set; }
        public int ResultCategoryId { get; set; }
        public List<ResultSubCategoryModel> ResultSubCategories { get; set; }
            public bool IsCompleted { get; set; }
        }
    public class ResultSubCategoryModel
    {
        public int Id { get; set; }
        public int ResultSegmentId { get; set; }
        public List<ResultQuestionModel> ResultQuestions { get; set; }
        public bool IsCompleted { get; set; }
        }
    public class ResultQuestionModel
    {
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public int ResultSubCategoryId { get; set; }
        public bool IsCorrect { get; set; }


    }

}
