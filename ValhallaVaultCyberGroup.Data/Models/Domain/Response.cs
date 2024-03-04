using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.Data.Models.Domain
{
    public class ResponseModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; }
    }
}
