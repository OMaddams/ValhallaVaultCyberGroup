namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class SegmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoriesId { get; set; }
        public CategoryModel Categories { get; set; }
        public List<SubCategoryModel> SubCategories { get; set; }

    }
}
