using System;
using Microsoft.AspNetCore.Mvc;
using Mission14_rtj34_API.Data;

namespace Mission14_rtj34_API.Controllers
{
    //setup API and path to controller
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }

        public IEnumerable<Movies> Get()
        {
            return context.Movies
                //Filter movies shown
                .Where(m => m.Edited == "Yes")
                .OrderBy(m => m.Title)
                .ToArray();
        }
    }
}

