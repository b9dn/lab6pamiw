using P06.Shared;
using P06.Shared.Films;
using P06Shop.Shared;
using P06Shop.Shared.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Shared.Services.FilmService
{
    public interface IFilmService
    {
        Task<ServiceResponse<List<Film>>> GetFilmAsync();

        Task<ServiceResponse<Film>> UpdateFilmAsync(Film film);

        Task<ServiceResponse<bool>> DeleteFilmAsync(int id);

        Task<ServiceResponse<Film>> CreateFilmAsync(Film film);

        Task<ServiceResponse<Film>> GetFilmByIdAsync(int id);

        Task<ServiceResponse<List<Film>>> SearchFilmAsync(string text, int page, int pageSize);

    }
}
