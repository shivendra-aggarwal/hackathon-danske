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
            QuestionAnswerMappings = new HashSet<QuestionAnswerMappingDTO>();
            QuizQuestionMappings = new HashSet<QuizQuestionMappingDTO>();
        }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string QuestionCode { get; set; }
        public int Duration { get; set; }
        //public QuestionType QuestionType { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }

        public ICollection<QuestionAnswerMappingDTO> QuestionAnswerMappings { get; set; }

        public ICollection<QuizQuestionMappingDTO> QuizQuestionMappings { get; set; }
    }
}
