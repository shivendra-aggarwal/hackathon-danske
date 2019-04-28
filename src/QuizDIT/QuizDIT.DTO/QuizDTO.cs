using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QuizDIT.Domain.Enums.Enums;

namespace QuizDIT.Domain
{
    public class QuizDTO
    {
        public QuizDTO()
        {
            QuizQuestionMappings = new HashSet<QuizQuestionMappingDTO>();
        }

        public int QuizId { get; set; }

        public string QuizName { get; set; }

        public string QuizType { get; set; }

        public DateTime QuizDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string QuizPassword { get; set; }

        public int Duration { get; set; }

        public bool IsStart { get; set; }
        public bool IsRegistered { get; set; }

        public ICollection<QuizQuestionMappingDTO> QuizQuestionMappings { get; set; }
    }
}
