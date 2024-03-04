using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SegmentId { get; set; }
        public SegmentModel Segment { get; set; }
        public List<QuestionModel> Questions { get; set; }

    }
}
