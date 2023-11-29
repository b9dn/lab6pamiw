using P06Shop.Shared;
using P06.Shared.Services.FilmService;
using P06.Shared.Films;
using P06Shop.Shared.Shop;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using P06Shop.Shared.Configuration;
using System.Net.Http.Json;

namespace P06Shop.Shared.Services.FilmService {
    public class FilmService : IFilmService {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        public FilmService(HttpClient httpClient, IOptions<AppSettings> appSettings) {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceResponse<Film>> CreateFilmAsync(Film film) {
            var response = await _httpClient.PostAsJsonAsync(_appSettings.BaseFilmEndpoint.AddFilmAsync, film);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Film>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteFilmAsync(int id) {
            // jesli uzyjemy / na poczatku to wtedy sciezka trakktowana jest od root czyli pomija czesc œrodkow¹ adresu 
            // zazwyczaj unikamy stosowania / na poczatku 
            var response = await _httpClient.DeleteAsync($"{_appSettings.BaseFilmEndpoint.DeleteFilmAsync}/{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
        }




        //// skopiowane z postmana 
        //public async Task<ServiceResponse<List<Film>>> GetFilmAsync()
        //{
        //    //var client = new HttpClient();   
        //    var request = new HttpRequestMessage(HttpMethod.Get, _appSettings.BaseFilmEndpoint.GetAllFilmEndpoint);
        //    var response = await _httpClient.SendAsync(request);
        //    response.EnsureSuccessStatusCode();        
        //    var json = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert.DeserializeObject<ServiceResponse<List<Film>>>(json);
        //    return result;
        //}


        // alternatywny sposób pobierania danych 
        public async Task<ServiceResponse<List<Film>>> GetFilmAsync() {
            try {
                var response = await _httpClient.GetAsync(_appSettings.BaseFilmEndpoint.GetFilmAsync);
                if (!response.IsSuccessStatusCode)
                    return new ServiceResponse<List<Film>> {
                        Success = false,
                        Message = "HTTP request failed"
                    };

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ServiceResponse<List<Film>>>(json)
                    ?? new ServiceResponse<List<Film>> { Success = false, Message = "Deserialization failed" };

                result.Success = result.Success && result.Data != null;

                return result;
            } catch (JsonException) {
                return new ServiceResponse<List<Film>> {
                    Success = false,
                    Message = "Cannot deserialize data"
                };
            } catch (Exception) {
                return new ServiceResponse<List<Film>> {
                    Success = false,
                    Message = "Network error"
                };
            }


        }

        public async Task<ServiceResponse<Film>> GetFilmByIdAsync(int id) {
            var response = await _httpClient.GetAsync(id.ToString());
            if (!response.IsSuccessStatusCode)
                return new ServiceResponse<Film> {
                    Success = false,
                    Message = "HTTP request failed"
                };

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Film>>(json)
                ?? new ServiceResponse<Film> { Success = false, Message = "Deserialization failed" };

            result.Success = result.Success && result.Data != null;

            return result;
        }


        public async Task<ServiceResponse<Film>> UpdateFilmAsync(Film film) {
            var response = await _httpClient.PutAsJsonAsync(_appSettings.BaseFilmEndpoint.UpdateFilmAsync, film);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Film>>();
            return result;
        }

        public async Task<ServiceResponse<List<Film>>> SearchFilmAsync(string text, int page, int pageSize) {

            try {
                string searchUrl = string.IsNullOrWhiteSpace(text) ? "" : $"/{text}";
                var response = await _httpClient.GetAsync(_appSettings.BaseFilmEndpoint.SearchFilmAsync + searchUrl + $"/{page}/{pageSize}");
                if (!response.IsSuccessStatusCode)
                    return new ServiceResponse<List<Film>> {
                        Success = false,
                        Message = "HTTP request failed"
                    };

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ServiceResponse<List<Film>>>(json)
                    ?? new ServiceResponse<List<Film>> { Success = false, Message = "Deserialization failed" };

                result.Success = result.Success && result.Data != null;

                return result;
            } catch (JsonException) {
                return new ServiceResponse<List<Film>> {
                    Success = false,
                    Message = "Cannot deserialize data"
                };
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);

                return new ServiceResponse<List<Film>> {
                    Success = false,
                    Message = "Network error"
                };
            }
        }
    }
}
