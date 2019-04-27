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
        public IEnumerable<QuizDTO> Get(string userEmail)
        {
            //var quizes = from q in _context.Quizs
            //             join d in _context.UserQuizes on q.QuizId equals d.QuizId
            //             join u in _context.Users on d.UserId equals u.UserId
            //             where u.UserEmail == userEmail
            //             select q;
            //var result =  Mapper.Map<IEnumerable<Quiz>, IEnumerable<QuizDTO>>(quizes.AsEnumerable()).ToList();
            //result.ToList().ForEach(r => r.IsStart = true);
            return null;
        }

        [Route("quiz/{quizid}/question")]
        [HttpGet]
        public QuestionDTO Get(int quizid)
        {
            var question = _context.Question.FirstOrDefault();
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
