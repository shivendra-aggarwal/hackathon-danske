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
            if (!context.Quizs.Any())
            {
                context.Quizs.Add(new Domain.Quiz()
                {
                    QuizId = 1,
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
            if (!context.Questions.Any())
            {
                context.Questions.Add(new Domain.Question()
                {
                    QuestionId = 1,
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
                context.Questions.Add(new Domain.Question()
                {
                    QuestionId = 2,
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
                context.Questions.Add(new Domain.Question()
                {
                    QuestionId = 3,
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

                context.Questions.Add(new Domain.Question()
                {
                    QuestionId = 4,
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

                context.Questions.Add(new Domain.Question()
                {
                    QuestionId = 5,
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
            if (!context.QuizQuestionMappings.Any())
            {
                context.QuizQuestionMappings.Add(new Domain.QuizQuestionMapping()
                {
                    QuizQuestionMappingId = 1,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 1,
                    QuestionId = 1,
                    QuizId = 1
                });

                context.QuizQuestionMappings.Add(new Domain.QuizQuestionMapping()
                {
                    QuizQuestionMappingId = 2,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 2,
                    QuestionId = 2,
                    QuizId = 1
                });
                context.QuizQuestionMappings.Add(new Domain.QuizQuestionMapping()
                {
                    QuizQuestionMappingId = 3,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 3,
                    QuestionId = 3,
                    QuizId = 1
                });

                context.QuizQuestionMappings.Add(new Domain.QuizQuestionMapping()
                {
                    QuizQuestionMappingId = 4,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    OrderId = 4,
                    QuestionId = 4,
                    QuizId = 1
                });
                context.QuizQuestionMappings.Add(new Domain.QuizQuestionMapping()
                {
                    QuizQuestionMappingId = 5,
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
            if (!context.Answers.Any())
            {
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 1,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Value types"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 2,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Reference types"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 3,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Pointer types"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 4,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "All of the above"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 5,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "true"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 6,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "false"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 7,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToDecimal"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 8,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToDouble"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 9,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToInt16"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 10,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "ToInt32"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 11,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "sizeof"
                });

                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 12,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "typeof"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 13,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "&"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 14,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "*"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 15,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Public"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 16,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Private"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 17,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    AnswerDescription = "Protected"
                });
                context.Answers.Add(new Domain.Answer()
                {
                    AnswerId = 18,
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
            if (!context.QuestionAnswerMappings.Any())
            {
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 1,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 2,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 3,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 4,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 5,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 6,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 7,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 8,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 9,
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

                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 10,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 11,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 12,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 13,
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
                context.QuestionAnswerMappings.Add(new Domain.QuestionAnswerMapping()
                {
                    QuestionAnswerMappingId = 14,
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
            if (!context.Users.Any())
            {
                context.Users.Add(new Domain.User()
                {
                    UserId = 1,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "singhal.s01@gmail.com",
                    UserName = "Anshul Singhal"
                });
                context.Users.Add(new Domain.User()
                {
                    UserId = 2,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "tn.prashant@gmail.com",
                    UserName = "Prashanth"
                });
                context.Users.Add(new Domain.User()
                {
                    UserId = 3,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserEmail = "shivendra.aggarwal@gmail.com",
                    UserName = "Shivendra "
                });
            }
        }

        public static void LoadUserQuiz(QuizDITDbContext context)
        {
            if (!context.UserQuizes.Any())
            {
                context.UserQuizes.Add(new Domain.UserQuiz()
                {
                    UserQuizId = 1,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserId = 1,
                    QuizId = 1
                });

                context.UserQuizes.Add(new Domain.UserQuiz()
                {
                    UserQuizId = 2,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserId = 2,
                    QuizId = 1
                });
                context.UserQuizes.Add(new Domain.UserQuiz()
                {
                    UserQuizId = 3,
                    CreatedBy = "Admin",
                    CreatedDateTime = System.DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "Admin",
                    ModifiedDateTime = System.DateTime.Now,
                    UserId = 3,
                    QuizId = 1
                });
            }
        }
    }
}
