using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Runtime { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string Genres { get; set; }

        public int Votes { get; set; }
    }
}
