using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class SegmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public CategoryModel Categories { get; set; }
        public List<SubCategoryModel> SubCategories { get; set; }

    }
}
