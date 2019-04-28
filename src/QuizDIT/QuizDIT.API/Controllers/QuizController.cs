﻿using System;
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
            : base(serviceProvider)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<QuizDTO> Get(string userEmail)
        {

            var quizes = from q in _context.Quiz
                         join d in _context.UserQuiz on q.QuizId equals d.QuizId
                         join u in _context.User on d.UserId equals u.UserId
                         where u.UserEmail == userEmail
                         select q;
            //var userQuizes = from uq in _context.UserQuiz
            //                 join d in _context.User on uq.UserId equals d.UserId
            //                 where d.user
            var result = Mapper.Map<IEnumerable<Quiz>, IEnumerable<QuizDTO>>(quizes.AsEnumerable()).ToList();
            result.ToList().ForEach(r => r.IsStart = true);
            return null;
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

                    if(question == null)
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
