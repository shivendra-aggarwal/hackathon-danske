using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class Answer : AuditEntity
    {
        public Answer()
        {
            QuestionAnswerMappings = new HashSet<QuestionAnswerMapping>();
        }
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
        public ICollection<QuestionAnswerMapping> QuestionAnswerMappings { get; set; }

    }
}
