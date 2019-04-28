using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerWebApp.Model
{
    public class Question
    {
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string QuestionCode { get; set; }
        public int Duration { get; set; }
        public string QuestionType { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }

        public int SelectedAnswer { get; set; }

        public List<Answer> AnswerList { get;set;}=new List<Answer>();

        public List<Question> GetQuestion(int QuizId, string Email)
        {
            List<Question> QuestionList = new List<Question>();
            QuestionList.Add(new Question()
            {
                QuizId=1,
                Award=1,
                Penalty=1,
                Duration=60,
                QuestionCode="123",
                QuestionDescription="Desc1",
                QuestionId=1,
                QuestionTitle="Title1",
                QuestionType= "ShortAnswer"

            });
            QuestionList.Add(new Question()
            {
                QuizId = 2,
                Award = 2,
                Penalty = 1,
                Duration = 60,
                QuestionCode = "123",
                QuestionDescription = "Desc2",
                QuestionId = 2,
                QuestionTitle = "Title2",
                QuestionType = "ShortAnswer"

            });
            QuestionList.Add(new Question()
            {
                QuizId = 1,
                Award = 1,
                Penalty = 1,
                Duration = 60,
                QuestionCode = "123",
                QuestionDescription = "Desc3",
                QuestionId = 3,
                QuestionTitle = "Title3",
                QuestionType = "MultipleChoice",
                AnswerList= new List<Answer>() {
                    new Answer(){ AnswerId=1, AnswerDescription="test" },
                    new Answer(){ AnswerId=2, AnswerDescription="test2" },
                    new Answer(){ AnswerId=3, AnswerDescription="test3" },
                    new Answer(){ AnswerId=4, AnswerDescription="test4" },
                }

            });
            QuestionList.Add(new Question()
            {
                QuizId = 1,
                Award = 1,
                Penalty = 1,
                Duration = 60,
                QuestionCode = "123",
                QuestionDescription = "Desc4",
                QuestionId = 4,
                QuestionTitle = "Title4",
                QuestionType = "MultipleChoice",
                AnswerList = new List<Answer>() {
                    new Answer(){ AnswerId=5, AnswerDescription="test5" },
                    new Answer(){ AnswerId=6, AnswerDescription="test6" },
                    new Answer(){ AnswerId=7, AnswerDescription="test7" },
                    new Answer(){ AnswerId=8, AnswerDescription="test8" },
                }

            });
            QuestionList.Add(new Question()
            {
                QuizId = 1,
                Award = 1,
                Penalty = 1,
                Duration = 60,
                QuestionCode = "123",
                QuestionDescription = "Desc5",
                QuestionId = 5,
                QuestionTitle = "Title5",
                QuestionType = "ShortAnswer"

            });
            QuestionList.Add(new Question()
            {
                QuizId = 1,
                Award = 1,
                Penalty = 1,
                Duration = 60,
                QuestionCode = "123",
                QuestionDescription = "Desc6",
                QuestionId = 6,
                QuestionTitle = "Title6",
                QuestionType = "MultipleChoice",
                AnswerList = new List<Answer>() {
                    new Answer(){ AnswerId=9, AnswerDescription="test9" },
                    new Answer(){ AnswerId=10, AnswerDescription="test10" },
                    new Answer(){ AnswerId=11, AnswerDescription="test11" },
                    new Answer(){ AnswerId=12, AnswerDescription="test12" },
                }

            });
            return QuestionList.Where(x=>x.QuizId==QuizId).ToList();
        }
    }

}
