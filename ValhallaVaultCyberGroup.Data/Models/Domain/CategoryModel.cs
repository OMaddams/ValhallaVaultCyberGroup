using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SegmentModel> Segments { get; set; }

    }
}
