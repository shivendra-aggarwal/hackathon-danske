using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain.Enums
{
    public class Enums
    {
        public enum QuizType
        {
            Public = 1,
            Private
        }

        public enum QuestionType
        {
            MultipleChoice = 1,
            ShortAnwer
        }
    }
}
