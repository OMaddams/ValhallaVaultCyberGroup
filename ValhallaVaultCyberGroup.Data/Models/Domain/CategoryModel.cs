using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<SegmentModel> Segments { get; set; }

    }
}
