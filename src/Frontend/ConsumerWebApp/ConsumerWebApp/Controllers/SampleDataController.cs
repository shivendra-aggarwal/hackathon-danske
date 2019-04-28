using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumerWebApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("quiz")]
        public IActionResult GetQuizList()
        {
            Quiz q = new Quiz();
            var results = q.getQuiz();
            return Ok(results);
        }

        [HttpPost("register")]
        public IActionResult PostregisterUser([FromBody]Quiz quiz)
        {
            quiz.IsRegistered = true;
            return Ok(quiz);
        }

        [HttpPut("startQuiz")]
        public IActionResult PutStartQuiz([FromBody]Quiz quiz)
        {
            quiz.IsStart = true;
            return Ok(quiz);
        }

        [HttpGet("question")]
        public IActionResult GetQuestionList(int QuizId, string Email, int QuestionId)
        {
            Question q = new Question();
            var results = q.GetQuestion(QuizId, Email);
            return Ok(results.Where(x => x.QuestionId == QuestionId + 1));

        }

        [HttpPost("postQuestion")]
        public IActionResult postQuestion([FromBody]Question question)
        {
            if (question.SelectedAnswer > 0)
                return Ok(question);
            else
                return NotFound(question);
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
