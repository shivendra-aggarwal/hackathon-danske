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

        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<QuizQuestionMapping> QuizQuestionMappings { get; set; }
        public DbSet<QuestionAnswerMapping> QuestionAnswerMapping { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserQuiz> UserQuiz { get; set; }
        public DbSet<UserQuizResponse> UserQuizResponses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
