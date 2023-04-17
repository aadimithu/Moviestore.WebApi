
using Moviestore.Core;
using Microsoft.AspNetCore.Mvc;

namespace Moviestor.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieServices _movieServices;
        public MoviesController(IMovieServices movieServices)
        {
            _movieServices = movieServices;

        }
        [HttpGet]
       
        public IActionResult GetMovies()
        {
            return Ok(_movieServices.GetMovies());
        }
 
    }
}