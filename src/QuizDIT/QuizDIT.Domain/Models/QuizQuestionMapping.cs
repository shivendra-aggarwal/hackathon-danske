using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class QuizQuestionMapping : AuditEntity
    {
        public int QuizQuestionMappingId { get; set; }

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public int OrderId { get; set; }

        public Quiz Quiz { get; set; }

        public Question Question { get; set; }
    }
}
