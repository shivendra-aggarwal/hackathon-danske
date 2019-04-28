using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace QuizQueResponseProducer
{
    public class ResponseProducer
    {
        public static void ProduceQuizQuestionReponse(int userId, int quizId, int questionId, int responseId)
        //public void ProduceQuizQuestionReponse()
        {
            var conf = new ProducerConfig { BootstrapServers = "localhost:9092" };

            Action<DeliveryReport<Null, string>> handler = r =>
                Console.WriteLine(!r.Error.IsError
                    ? $"Delivered message to {r.TopicPartitionOffset}"
                    : $"Delivery Error: {r.Error.Reason}");

            using (var p = new ProducerBuilder<Null, string>(conf).Build())
            {
                //UserId, QuizId, QuestionId, ResponseId
                QuizQueResponse quizQueResponse = new QuizQueResponse();
                quizQueResponse.UserId = userId;
                quizQueResponse.QuizId = quizId;
                quizQueResponse.QuestionId = questionId;
                quizQueResponse.ResponseId = responseId;

                p.Produce("testtopic", new Message<Null, string> { Value = JsonConvert.SerializeObject(quizQueResponse) }, handler);

                p.Flush(TimeSpan.FromSeconds(10));
            }
            Console.WriteLine();
        }
    }
}
