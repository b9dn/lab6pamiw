using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P06.Shared.Films;
using P06Shop.Shared.Shop;

namespace P07Film.DataSeeder
{
    public class FilmSeeder
    {

        public static List<Film> GenerateFilmData() {
            int filmId = 1;
            var filmFaker = new Faker<Film>("pl")
                .UseSeed(56789)
                .RuleFor(x => x.Title, x => x.Lorem.Word())
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x => x.Id, x => filmId++)
                .RuleFor(x => x.Barcode, x => x.Commerce.Ean13().Substring(12))
                .RuleFor(x => x.Price, x => x.Random.Double(1, 1000))
                .RuleFor(x => x.ReleaseDate, x => x.Date.Past());

            return filmFaker.Generate(50).ToList();

        }
    }
}
