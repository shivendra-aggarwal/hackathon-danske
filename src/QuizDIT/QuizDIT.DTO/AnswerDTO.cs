using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class AnswerDTO
    {
        public AnswerDTO()
        {
            QuestionAnswerMappings = new HashSet<QuestionAnswerMappingDTO>();
        }

        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
        public IEnumerable<QuestionAnswerMappingDTO> QuestionAnswerMappings { get; set; }

    }
}
