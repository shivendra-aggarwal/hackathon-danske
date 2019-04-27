using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class UserQuiz : AuditEntity
    {
        public UserQuiz()
        {
            UserQuizResponses = new HashSet<UserQuizResponse>();
        }

        public int UserQuizId { get; set; }

        public DateTime RegisterationDateTime { get; set; }

        public DateTime StartDateTime { get; set; }

        public int UserId { get; set; }

        public int QuizId { get; set; }

        public User User { get; set; }

        public Quiz Quiz { get; set; }

        public ICollection<UserQuizResponse> UserQuizResponses { get; set; }
    }
}
