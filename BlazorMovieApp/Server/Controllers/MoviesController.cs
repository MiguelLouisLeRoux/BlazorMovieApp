using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorMovieApp.Shared;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorMovieApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IMoviesList _moviesList;
        public MoviesController(IMoviesList moviesList)
        {
            _moviesList = moviesList;
        }

        [HttpGet("Movies")]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(_moviesList.GetMovies());
        }

        [HttpPost("AddMovie")]
        public async Task<IActionResult> AddMovie(Movie content_)
        {
           //Movie? newlist = Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>( content_);
            //_moviesList.AddMovie(newlist.Image, newlist.Title, newlist.Genre);
            _moviesList.AddMovie(content_.Image, content_.Title, content_.Genre);

            return Ok(_moviesList.GetMovies());
        }

        [HttpPut("UpdateMovie/{id}/{movieTitle}/{movieGenre}")]
        public async Task<IActionResult> UpdateMovie(int id, string movieTitle, string movieGenre)
        {
            _moviesList.EditMovie(id, movieTitle, movieGenre);
            return Ok(_moviesList.GetMovies());
        }

        [HttpDelete("DeleteMovie/{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            _moviesList.DeleteMovie(id);
            return Ok(_moviesList.GetMovies());
        }

        [HttpGet("GetDeletedMovies")]
        public async Task<IActionResult> GetDeletedMovies()
        {
            return Ok(_moviesList.GetDeletedMovies());
        }

        [HttpGet("GetLikedMovies")]
        public async Task<IActionResult> GetLikedMovies()
        {
            return Ok(_moviesList.GetLikedMovies());
        }

        [HttpPut("AddLikedMovie/{id}")]
        public async Task<IActionResult> AddLikedMovie(int id)
        {
            _moviesList.AddLikedMovie(id);
            return Ok(_moviesList.GetMovies());
        }

        [HttpDelete("DeleteLikedMovie/{id}")]
        public async Task<IActionResult> DeleteLikedMovie(int id)
        {
            _moviesList.RemoveLikedMovie(id);
            return Ok(_moviesList.GetLikedMovies());
        }
    }
}
