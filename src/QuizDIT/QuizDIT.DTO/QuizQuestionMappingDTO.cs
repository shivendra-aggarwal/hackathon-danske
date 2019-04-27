using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class QuizQuestionMappingDTO
    {
        public int QuizQuestionMappingId { get; set; }

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public int OrderId { get; set; }

        public QuizDTO Quiz { get; set; }

        public QuestionDTO Question { get; set; }
    }
}
