using System;
using Microsoft.AspNetCore.Mvc;
using Mission14_rtj_API.Models;

namespace Mission14_rtj_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
	{
        private MovieDbContext context;

        public MovieController (MovieDbContext temp)
        {
            context = temp;
        }

        public IEnumerable<Movie> Get()
        {
            return context.Movies
               //Filter movies shown
               .Where(m => m.Edited == "Yes")
               .OrderBy(m => m.Title)
               .ToArray();
        }
	}
}

