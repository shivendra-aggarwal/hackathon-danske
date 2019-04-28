using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizQueResponseProducer
{
    public class QuizQueResponse
    {
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        public int ResponseId { get; set; }
    }
}
