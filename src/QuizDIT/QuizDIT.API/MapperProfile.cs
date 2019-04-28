using AutoMapper;
using QuizDIT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDIT.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Quiz, QuizDTO>();
            CreateMap<QuizDTO, Quiz>();

            CreateMap<Answer, AnswerDTO>();
            CreateMap<AnswerDTO, Answer>();

            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, Question>();
        }
    }
}
