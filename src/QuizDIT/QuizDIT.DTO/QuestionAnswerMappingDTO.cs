using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class QuestionAnswerMappingDTO
    {
        public int QuestionAnswerMappingId { get; set; }

        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public bool IsCorrect { get; set; }
        public int OrderId { get; set; }

        public QuestionDTO Question { get; set; }

        public AnswerDTO Answer { get; set; }

    }
}
