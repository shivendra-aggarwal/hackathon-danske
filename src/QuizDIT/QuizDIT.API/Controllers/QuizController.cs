using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizDIT.Data.EFCore;
using QuizDIT.Domain;
using QuizQueResponseProducer;

namespace QuizDIT.API.Controllers
{
    [Route("v{version:apiVersion}/[controller]")]
    public class QuizController : BaseController
    {
        private readonly QuizDITDbContext _context;

        public QuizController(IServiceProvider serviceProvider, QuizDITDbContext context)
            : base(serviceProvider)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<QuizDTO> Get(string userEmail)
        {
            return GetQuiz(userEmail);
        }

        private IEnumerable<QuizDTO> GetQuiz(string userEmail)
        {
            var allquizes = _context.Quiz.ToList();
            var quizes = from q in _context.Quiz
                         join d in _context.UserQuiz on q.QuizId equals d.QuizId
                         join u in _context.User on d.UserId equals u.UserId
                         where u.UserEmail == userEmail
                         select d;
            var result = Mapper.Map<IEnumerable<Quiz>, IEnumerable<QuizDTO>>(allquizes.AsEnumerable()).ToList();
            result.ToList().ForEach(r =>
            {
                if (quizes.Any(q => q.QuizId == r.QuizId))
                {
                    r.IsRegistered = true;
                    r.IsStart = quizes.FirstOrDefault(q => q.QuizId == r.QuizId).IsStart;
                }
                
                r.Duration = 60;
            }
            );
            return result;
        }

        [Route("quiz/{quizid}/user/{userId}/question/{questionid}")]
        [HttpGet]
        public QuestionDTO Get(int quizid, int userId, int questionid = 0)
        {
            var userQuiz = _context.UserQuiz.FirstOrDefault(uq => uq.QuizId == quizid && uq.UserId == userId);
            if (userQuiz != null)
            {
                var questions = (from q in _context.QuizQuestionMapping
                                 join quest in _context.Question on q.QuestionId equals quest.QuestionId
                                 where q.QuizId == userQuiz.QuizId
                                 orderby q.OrderId
                                 select quest).ToList();
                Question question = null;
                if (questionid == 0)
                {
                    question = questions.FirstOrDefault();
                }
                else
                {
                    question = questions.Where(q => q.QuestionId > questionid).FirstOrDefault();

                    if (question == null)
                    {
                        return null;
                    }
                }

                var questionDTO = Mapper.Map<Question, QuestionDTO>(question);
                questionDTO.Answers = (from m in _context.QuestionAnswerMapping
                                       join a in _context.Answer on m.AnswerId equals a.AnswerId
                                       where m.QuestionId == questionDTO.QuestionId
                                       select new AnswerDTO()
                                       {
                                           AnswerId = a.AnswerId,
                                           AnswerDescription = a.AnswerDescription
                                       }).ToList();

                return questionDTO;

            }

            return null;
        }

        [HttpPost("RegisterQuiz")]
        public IActionResult RegisterQuiz(string userEmail, int quizid)
        {
            var user = _context.User.FirstOrDefault(u => u.UserEmail == userEmail);
            var quiz = _context.Quiz.FirstOrDefault(q => q.QuizId == quizid);

            var userQuiz = new UserQuiz();
            userQuiz.QuizId = quiz.QuizId;
            userQuiz.UserId = user.UserId;
            userQuiz.UserRegisterDate = DateTime.Now;
            userQuiz.CreatedBy = "Admin";
            userQuiz.ModifiedBy = "Admin";
            userQuiz.CreatedDateTime = DateTime.Now;
            userQuiz.ModifiedDateTime = DateTime.Now;
            _context.UserQuiz.Add(userQuiz);
            _context.SaveChanges();

            var quizes = GetQuiz(userEmail);
            return Ok(quizes.FirstOrDefault());
        }

        [HttpPut("StartQuiz")]
        public IActionResult StartQuiz(string userEmail, int quizid)
        {
            var userQuiz = (from q in _context.UserQuiz
                       join d in _context.User on q.UserId equals d.UserId
                       where d.UserEmail == userEmail && q.QuizId == quizid
                       select q).FirstOrDefault();

            userQuiz.IsStart = true;
            _context.SaveChanges();

            var quizes = GetQuiz(userEmail);
            return Ok(quizes.FirstOrDefault());
        }


        [Route("user/{userid}/quiz/{quizid}/question/{questionid}/response/{responseid}")]
        [HttpPost]
        public IActionResult PublishMessage(int userid, int quizid, int questionid, int responseid = 0)
        {
            ResponseProducer.ProduceQuizQuestionReponse(userid, quizid, questionid, responseid);

            return Ok();
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
