using Microsoft.AspNetCore.Mvc;
using P04WeatherForecastAPI.Client.Models;
using P06Shop.Shared;
using P06.Shared.Services.FilmService;
using P06.Shared.Films;
using P06Shop.Shared.Shop;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : Controller
    {
        private readonly IFilmService _filmService;
        private readonly ILogger<FilmController> _logger;
        public FilmController(IFilmService filmService, ILogger<FilmController> logger) {
            _filmService = filmService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Film>>>> GetFilm() {
            _logger.Log(LogLevel.Information, "Invoked GetFilm Method in controller");

            var result = await _filmService.GetFilmAsync();

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetFilmById(int id) {

            var result = await _filmService.GetFilmByIdAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceResponse<List<Film>>>> SearchFilm(string? text = null, int page = 1, int pageSize = 10) {
            _logger.Log(LogLevel.Information, "Invoked SearchFilm Method in controller");

            var result = await _filmService.SearchFilmAsync(text, page, pageSize);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }


        [HttpPut("UpdateFilm")]
        public async Task<ActionResult<ServiceResponse<Film>>> UpdateFilm([FromBody] Film film) {

            var result = await _filmService.UpdateFilmAsync(film);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPost("CreateFilm")]
        public async Task<ActionResult<ServiceResponse<Film>>> CreateFilm([FromBody] Film film) {
            var result = await _filmService.CreateFilmAsync(film);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        // http:localhost/api/product/delete?id=4
        // http:localhost/api/product/4 dla api REST
        [HttpDelete("DeleteFilm/{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteFilm([FromRoute] int id) {
            var result = await _filmService.DeleteFilmAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

    }
}
