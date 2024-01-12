using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private static readonly List<Movie> movies = new List<Movie>()
        {
            new() {Id=1,Mname="jaihind",Gen="Action"},
            new() {Id=2,Mname="Endiran",Gen="Si-Fi"},
            new() {Id=3,Mname="The nun",Gen="Horror"}

        };
        [HttpGet(Name = "GetMovies")]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }
    }
}
