﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class UserQuizResponse : AuditEntity
    {
        public int UserQuizResponseId { get; set; }

        public int UserQuizId { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public UserQuiz UserQuiz { get; set; }

    }
}
