using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QuizDIT.Domain.Enums.Enums;

namespace QuizDIT.Domain
{
    public class Quiz : AuditEntity
    {
        public Quiz()
        {
            QuizQuestionMappings = new HashSet<QuizQuestionMapping>();
        }
        public int QuizId { get; set; }

        public string QuizName { get; set; }

        public QuizType QuizType { get; set; }

        public DateTime QuizDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string QuizPassword { get; set; }

        public ICollection<QuizQuestionMapping> QuizQuestionMappings { get; set; }
    }
}
