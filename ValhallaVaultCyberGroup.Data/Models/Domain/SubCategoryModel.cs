using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class SubCategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SegmentId { get; set; }
        public SegmentModel Segment { get; set; }
        public List<QuestionModel> Questions { get; set; }

    }
}
