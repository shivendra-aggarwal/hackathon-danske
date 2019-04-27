using Microsoft.EntityFrameworkCore;
using QuizDIT.Domain;
using System;

namespace QuizDIT.Data.EFCore
{
    public class QuizDITDbContext : DbContext
    {
        public QuizDITDbContext(DbContextOptions<QuizDITDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuizQuestionMapping> QuizQuestionMappings { get; set; }
        public DbSet<QuestionAnswerMapping> QuestionAnswerMappings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserQuiz> UserQuizes { get; set; }
        public DbSet<UserQuizResponse> UserQuizResponses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
