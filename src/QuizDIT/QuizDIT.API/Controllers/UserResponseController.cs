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
    public class UserResponseController : BaseController
    {
        private readonly QuizDITDbContext _context;
        public UserResponseController(IServiceProvider serviceProvider, QuizDITDbContext context)
            : base(serviceProvider)
        {
            _context = context;
        }

        [Route("user/{userid}/quiz/{quizid}/question/{questionid}/response/{responseid}")]
        [HttpPost]
        public IActionResult SubmitResponse(int userid,int quizid,int questionid,int responseid)
        {
            var userQuiz = _context.UserQuiz.FirstOrDefault(uq => uq.UserId == userid && uq.QuizId == quizid);

            if (userQuiz != null)
            {
                var quizResponse = new UserQuizResponse();
                quizResponse.IsCorrect = true;
                quizResponse.UserQuizId = userQuiz.UserQuizId;
                quizResponse.IsDeleted = false;
                quizResponse.QuestionId = questionid;
                quizResponse.CreatedBy = "Admin";
                quizResponse.ModifiedBy = "Admin";
                quizResponse.CreatedDateTime = DateTime.Now;
                quizResponse.ModifiedDateTime = DateTime.Now;

                _context.Add(quizResponse);

                _context.SaveChanges();

            }


            return Ok();
        }

        [Route("user/{userid}/quiz/{quizid}/question/{questionid}/response/{responseid}")]
        [HttpPost]
        public IActionResult PublishMessage(int userid, int quizid, int questionid, int responseid)
        {
            ResponseProducer.ProduceQuizQuestionReponse(userid, quizid, questionid, responseid);
            
            return Ok();
        }
    }
}