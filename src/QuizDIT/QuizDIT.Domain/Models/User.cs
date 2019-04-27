using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class User : AuditEntity
    {
        public User()
        {
            UserQuizes = new HashSet<UserQuiz>();
        }
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public ICollection<UserQuiz> UserQuizes { get; set; }
    }
}
