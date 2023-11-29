using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Shared.Films
{
    public class Film
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } // director

        public string Barcode { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
