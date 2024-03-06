using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public List<ResponseModel> Responses { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategoryModel SubCategory { get; set; }
    }
}
