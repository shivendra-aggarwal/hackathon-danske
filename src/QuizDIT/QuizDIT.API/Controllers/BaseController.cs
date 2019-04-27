using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace QuizDIT.API.Controllers
{
    public abstract class BaseController : Controller
    {
        public IMapper Mapper { get; }

        public IServiceProvider ServiceProvider { get; set; }

        public BaseController(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
            Mapper = ServiceProvider.GetService<IMapper>();
        }
    }
}
