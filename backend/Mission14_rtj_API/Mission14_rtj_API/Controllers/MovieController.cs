using System;
using Microsoft.AspNetCore.Mvc;
using Mission14_rtj_API.Models;

namespace Mission14_rtj_API.Controllers
{
    //Creating the API controller for the Movie Class
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
            //Edits the data to only show movies that have been edited
            //Also orders them by title
            return context.Movies
               .Where(m => m.Edited == "Yes")
               .OrderBy(m => m.Title)
               .ToArray();
        }
	}
}

