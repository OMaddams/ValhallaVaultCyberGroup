using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberGroup.App.Services
{
    public class QuestionService
    {

        public HttpClient Client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7191/api/") 
        };

       
    }
}
