using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class QuestionDTO
    {
        public QuestionDTO()
        {
            QuizQuestionMappings = new HashSet<QuizQuestionMappingDTO>();
            Answers = new HashSet<AnswerDTO>();
        }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string QuestionCode { get; set; }
        public int Duration { get; set; }
        public string QuestionType { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }

        public int QuizId { get; set; }

        public ICollection<AnswerDTO> Answers { get; set; }

        public ICollection<QuizQuestionMappingDTO> QuizQuestionMappings { get; set; }
    }
}
