using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QuizDIT.Domain.Enums.Enums;

namespace QuizDIT.Domain
{
    public class Question : AuditEntity
    {
        public Question()
        {
            QuestionAnswerMappings = new HashSet<QuestionAnswerMapping>();
            QuizQuestionMappings = new HashSet<QuizQuestionMapping>();
        }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string QuestionCode { get; set; }
        public int Duration { get; set; }
        public QuestionType QuestionType { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }

        public ICollection<QuestionAnswerMapping> QuestionAnswerMappings { get; set; }

        public ICollection<QuizQuestionMapping> QuizQuestionMappings { get; set; }
    }
}
