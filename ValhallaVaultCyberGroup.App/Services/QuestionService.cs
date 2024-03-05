using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ValhallaVaultCyberGroup.Data.Models.Domain;

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
