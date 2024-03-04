using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public List<ResponseModel> Responses { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategoryModel SubCategory { get; set; }
    }
}
