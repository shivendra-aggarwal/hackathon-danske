using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.Domain
{
    public class UserDTO
    {
        public UserDTO()
        {
            UserQuizes = new HashSet<UserQuizDTO>();
        }
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public ICollection<UserQuizDTO> UserQuizes { get; set; }
    }
}
