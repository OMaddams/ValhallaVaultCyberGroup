using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public List<ResponseModel> Responses { get; set; }

        public int SubCategoryId { get; set; }
        public int SubCategoryModel { get; set; }
    }
}
