using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using ValhallaVaultCyberGroup.Data.Repositories;
using ValhallaVaultCyberGroup.Data.Models.Domain;

namespace ValhallaVaultCyberGroup.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly IQuestionsRepo _questionsRepo;


        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve // Konfigurering av JSON-serialisering
        };


        public QuizController(IQuestionsRepo questionsRepo)
        {
            _questionsRepo = questionsRepo;
        }


        //Get: api /Tickets
        [HttpGet]

        public async Task <IActionResult> GetAllQuestionsAsync()
        {
            List<QuestionModel> allQuestions = await _questionsRepo.GetAllQuestionsAsync(); 
            if (allQuestions == null) 
            { 
                return NotFound();
            }

            else
            {
                var questionsJson = JsonSerializer.Serialize(allQuestions, _jsonSerializerOptions);
                return Ok(questionsJson);
            }
        }

    }
}
