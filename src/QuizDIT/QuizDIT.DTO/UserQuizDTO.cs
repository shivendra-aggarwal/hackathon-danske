using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class UserQuizDTO : AuditEntity
    {
        public UserQuizDTO()
        {
            UserQuizResponses = new HashSet<UserQuizResponse>();
        }

        public int UserQuizId { get; set; }

        public DateTime RegisterationDateTime { get; set; }

        public DateTime StartDateTime { get; set; }

        public int UserId { get; set; }

        public int QuizId { get; set; }

        public UserDTO User { get; set; }

        public QuizDTO Quiz { get; set; }

        public ICollection<UserQuizResponse> UserQuizResponses { get; set; }
    }
}
