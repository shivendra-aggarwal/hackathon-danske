using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuizDIT.Data.EFCore
{
    public class InitializeDb
    {
        public static void LoadQuiz(QuizDITDbContext context)
        {
            if (!context.Quiz.Any())
            {
                context.Quiz.Add(new Domain.Quiz()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuizName = "C#",
                    QuizDate = DateTime.Now.AddDays(2),
                    QuizType = Domain.Enums.Enums.QuizType.Public
                });

                context.SaveChanges();
            }

        }

        public static void LoadQuestions(QuizDITDbContext context)
        {
            if (!context.Question.Any())
            {
                context.Question.Add(new Domain.Question()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuestionTitle = "Variable types",
                    QuestionDescription = "Which of the following variable types can be assigned a value directly in C#?",
                    Duration = 30,
                    QuestionType = Domain.Enums.Enums.QuestionType.MultipleChoice,
                    Award = 1,
                    Penalty = -1

                });
                context.Question.Add(new Domain.Question()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuestionTitle = "Value type",
                    QuestionDescription = "Value type variables in C# are derived from the class System.ValueType?",
                    Duration = 30,
                    QuestionType = Domain.Enums.Enums.QuestionType.MultipleChoice,
                    Award = 1,
                    Penalty = -1

                });
                context.Question.Add(new Domain.Question()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuestionTitle = "floating point",
                    QuestionDescription = "Which of the following converts a floating point or integer type to a decimal type in C#?",
                    Duration = 30,
                    QuestionType = Domain.Enums.Enums.QuestionType.MultipleChoice,
                    Award = 1,
                    Penalty = -1

                });

                context.Question.Add(new Domain.Question()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuestionTitle = "operator",
                    QuestionDescription = "Which of the following operator returns the address of an variable in C#?",
                    Duration = 30,
                    QuestionType = Domain.Enums.Enums.QuestionType.MultipleChoice,
                    Award = 1,
                    Penalty = -1

                });

                context.Question.Add(new Domain.Question()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    QuestionTitle = "child classes",
                    QuestionDescription = "Which of the following access specifier in C# allows a child class to access the member variables and member functions of its base class?",
                    Duration = 45,
                    QuestionType = Domain.Enums.Enums.QuestionType.MultipleChoice,
                    Award = 1,
                    Penalty = -1

                });

                context.SaveChanges();
            }
        }

        public static void LoadQuestionMappings(QuizDITDbContext context)
        {
            if (!context.QuizQuestionMapping.Any())
            {
                context.QuizQuestionMapping.Add(new Domain.QuizQuestionMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 1,
                    QuestionId = 1,
                    QuizId = 1,
                });

                context.QuizQuestionMapping.Add(new Domain.QuizQuestionMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 2,
                    QuestionId = 2,
                    QuizId = 1
                });
                context.QuizQuestionMapping.Add(new Domain.QuizQuestionMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 3,
                    QuestionId = 3,
                    QuizId = 1
                });

                context.QuizQuestionMapping.Add(new Domain.QuizQuestionMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 4,
                    QuestionId = 4,
                    QuizId = 1
                });
                context.QuizQuestionMapping.Add(new Domain.QuizQuestionMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 5,
                    QuestionId = 5,
                    QuizId = 1
                });

                context.SaveChanges();
            }

        }

        public static void LoadAnswers(QuizDITDbContext context)
        {
            if (!context.Answer.Any())
            {
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Value types"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Reference types"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Pointer types"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "All of the above"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "true"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "false"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToDecimal"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToDouble"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToInt16"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToInt32"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "sizeof"
                });

                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "typeof"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "&"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "*"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Public"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Private"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Protected"
                });
                context.Answer.Add(new Domain.Answer()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Internal"
                });
                context.SaveChanges();
            }
        }

        public static void LoadQuestionAnswerMappings(QuizDITDbContext context)
        {
            if (!context.QuestionAnswerMapping.Any())
            {
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 1,
                    QuestionId = 1,
                    IsCorrect = true,
                    OrderId = 1,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 2,
                    QuestionId = 1,
                    IsCorrect = false,
                    OrderId = 2,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 3,
                    QuestionId = 1,
                    IsCorrect = false,
                    OrderId = 3,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 4,
                    QuestionId = 1,
                    IsCorrect = false,
                    OrderId = 4,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 5,
                    QuestionId = 2,
                    IsCorrect = false,
                    OrderId = 1,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 6,
                    QuestionId = 2,
                    IsCorrect = false,
                    OrderId = 2,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 7,
                    QuestionId = 3,
                    IsCorrect = false,
                    OrderId = 1,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 8,
                    QuestionId = 3,
                    IsCorrect = false,
                    OrderId = 2,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 9,
                    QuestionId = 3,
                    IsCorrect = false,
                    OrderId = 3,
                });

                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 10,
                    QuestionId = 3,
                    IsCorrect = false,
                    OrderId = 4,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 11,
                    QuestionId = 4,
                    IsCorrect = false,
                    OrderId = 1,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 12,
                    QuestionId = 4,
                    IsCorrect = false,
                    OrderId = 2,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 13,
                    QuestionId = 4,
                    IsCorrect = false,
                    OrderId = 3,
                });
                context.QuestionAnswerMapping.Add(new Domain.QuestionAnswerMapping()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerId = 14,
                    QuestionId = 4,
                    IsCorrect = false,
                    OrderId = 4,
                });
                context.SaveChanges();
            }
        }

        public static void LoadUsers(QuizDITDbContext context)
        {
            if (!context.User.Any())
            {
                context.User.Add(new Domain.User()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "singhal.s01@gmail.com",
                    UserName = "Anshul Singhal"
                });
                context.User.Add(new Domain.User()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "tn.prashant@gmail.com",
                    UserName = "Prashanth"
                });
                context.User.Add(new Domain.User()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "shivendra.aggarwal@gmail.com",
                    UserName = "Shivendra "
                });
                context.SaveChanges();
            }
        }

        public static void LoadUserQuiz(QuizDITDbContext context)
        {
            if (!context.UserQuiz.Any())
            {
                context.UserQuiz.Add(new Domain.UserQuiz()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserId = 1,
                    QuizId = 1
                });

                context.UserQuiz.Add(new Domain.UserQuiz()
                {
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserId = 2,
                    QuizId = 1
                });
                
                context.SaveChanges();
            }
        }
    }
}
