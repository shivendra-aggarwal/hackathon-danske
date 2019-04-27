using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizDIT.Data.EFCore;
using QuizDIT.Domain;

namespace QuizDIT.API.Controllers
{
    [Route("v{version:apiVersion}/[controller]")]
    public class QuizController : BaseController
    {
        private readonly QuizDITDbContext _context;

        public QuizController(IServiceProvider serviceProvider, QuizDITDbContext context)
            :base(serviceProvider)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<QuizDTO> Get()
        {
            var quizes = _context.Quizs.ToList();
            return Mapper.Map<IEnumerable<Quiz>, IEnumerable<QuizDTO>>(quizes.AsEnumerable());
        }

        [Route("quiz/{quizid}/question")]
        [HttpGet]
        public QuestionDTO Get(int quizid)
        {
            var question = _context.Questions.FirstOrDefault();
            return Mapper.Map<Question, QuestionDTO>(question);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
