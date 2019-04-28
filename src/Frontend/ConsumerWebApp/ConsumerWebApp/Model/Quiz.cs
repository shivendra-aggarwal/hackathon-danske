using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerWebApp.Model
{
    public class Quiz
    {
        public int QuizId { get; set; }

        public string QuizName { get; set; }

        public string QuizType { get; set; }

        public DateTime QuizDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string QuizPassword { get; set; }

        public bool IsStart { get; set; } = false;
        public bool IsRegistered { get; set; } = false;
        public string Email { get; set; }
        public int Duration { get; set; } = 60;

        public List<Quiz> getQuiz()
        {
            List<Quiz> quizzes = new List<Quiz>();
            quizzes.Add(new Quiz()
            {
                QuizId = 1,
                QuizName = "C-Sharp",
                QuizType = "public",
                QuizDate = DateTime.Now.AddDays(2),
                StartTime = DateTime.Now.AddMinutes(10),
                EndTime = DateTime.Now.AddMinutes(40),
                QuizPassword = string.Empty
            });
            quizzes.Add(new Quiz()
            {
                QuizId = 2,
                QuizName = "C-Sharp1",
                QuizType = "public",
                QuizDate = DateTime.Now.AddDays(2),
                StartTime = DateTime.Now.AddMinutes(10),
                EndTime = DateTime.Now.AddMinutes(40),
                QuizPassword = string.Empty
            });
            quizzes.Add(new Quiz()
            {
                QuizId = 3,
                QuizName = "C-Sharp2",
                QuizType = "public",
                QuizDate = DateTime.Now.AddDays(2),
                StartTime = DateTime.Now.AddMinutes(10),
                EndTime = DateTime.Now.AddMinutes(40),
                QuizPassword = string.Empty
            });
            quizzes.Add(new Quiz()
            {
                QuizId = 4,
                QuizName = "C-Sharp4",
                QuizType = "public",
                QuizDate = DateTime.Now.AddDays(2),
                StartTime = DateTime.Now.AddMinutes(10),
                EndTime = DateTime.Now.AddMinutes(40),
                QuizPassword = string.Empty
            });
            quizzes.Add(new Quiz()
            {
                QuizId = 5,
                QuizName = "C-Sharp5",
                QuizType = "public",
                QuizDate = DateTime.Now.AddDays(2),
                StartTime = DateTime.Now.AddMinutes(10),
                EndTime = DateTime.Now.AddMinutes(40),
                QuizPassword = string.Empty
            });


            return quizzes;
        }
    }
}
