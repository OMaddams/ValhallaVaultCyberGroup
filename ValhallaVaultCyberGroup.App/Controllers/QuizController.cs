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
        [HttpGet("Questions")]

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


        [HttpGet("SingleQuestion/{id}")]

        public async Task<IActionResult> GetQuestionAsync(int id)
        {
            QuestionModel? question = await _questionsRepo.GetQuestionAsync(id);
       if(question == null)
            {
                return NotFound();
            }

       else
            {
                var questionJson = JsonSerializer.Serialize(question, _jsonSerializerOptions);
                return Ok(questionJson);
            }
        
        }


        //Get: api /Tickets
        [HttpGet("Responses")]

        public async Task<IActionResult> GetAllResponsesAsync()
        {
            List<ResponseModel> allResponses = await _questionsRepo.GetAllResponsesAsync();
            if (allResponses == null)
            {
                return NotFound();
            }

            else
            {
                var responsesJson = JsonSerializer.Serialize(allResponses, _jsonSerializerOptions);
                return Ok(responsesJson);
            }
        }

      
        [HttpGet("SingleResponse/{id}")]

        public async Task<IActionResult> GetResponseAsync(int id)
        {
            ResponseModel? response = await _questionsRepo.GetResponseAsync(id);
            if (response == null)
            {
                return NotFound();
            }

            else
            {
                var responseJson = JsonSerializer.Serialize(response, _jsonSerializerOptions);
                return Ok(responseJson);
            }

        }


        [HttpGet("Categories")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            List<CategoryModel> allCategories = await _questionsRepo.GetAllAsync();
            if (allCategories == null)
            {
                return NotFound();
            }

            else
            {
                var categoriesJson = JsonSerializer.Serialize(allCategories, _jsonSerializerOptions);
                return Ok(categoriesJson);
            }
        }


        [HttpGet("SingleCategory/{id}")]

        public async Task<IActionResult> GetCategoryAsync(int id)
        {
            CategoryModel? category = await _questionsRepo.GetCategoryAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            else
            {
                var categoryJson = JsonSerializer.Serialize(category, _jsonSerializerOptions);
                return Ok(categoryJson);
            }

        }

        [HttpGet("Segments")]
        public async Task<IActionResult> GetAllSegmentAsync()
        {
            List<SegmentModel> allSegments = await _questionsRepo.GetAllSegmentsAsync();
            if (allSegments == null)
            {
                return NotFound();
            }

            else
            {
                var segmentsJson = JsonSerializer.Serialize(allSegments, _jsonSerializerOptions);
                return Ok(segmentsJson);
            }
        }


        [HttpGet("SingleSegment/{id}")]

        public async Task<IActionResult> GetSegmentAsync(int id)
        {
            SegmentModel? segment = await _questionsRepo.GetSegmentAsync(id);
            if (segment == null)
            {
                return NotFound();
            }

            else
            {
                var segmentJson = JsonSerializer.Serialize(segment, _jsonSerializerOptions);
                return Ok(segmentJson);
            }

        }

        [HttpGet("SubCategories")]
        public async Task<IActionResult> GetAllSubCategoriesAsync()
        {
            List<SubCategoryModel> allSubCategories = await _questionsRepo.GetAllSubCategoriesAsync();
            if (allSubCategories == null)
            {
                return NotFound();
            }

            else
            {
                var subCategoriesJson = JsonSerializer.Serialize(allSubCategories, _jsonSerializerOptions);
                return Ok(subCategoriesJson);
            }
        }


        [HttpGet("SingleSubCategory/{id}")]

        public async Task<IActionResult> GetSubCategoryAsync(int id)
        {
            SubCategoryModel? subCategory = await _questionsRepo.GetSubCategoryAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }

            else
            {
                var subCategoryJson = JsonSerializer.Serialize(subCategory, _jsonSerializerOptions);
                return Ok(subCategoryJson);
            }

        }

    }
}
