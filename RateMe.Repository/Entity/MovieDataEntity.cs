using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.Repository.Entity
{
    [Table("dbo.MovieData")]
    public class MovieDataEntity
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Runtime { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string Genres { get; set; }

        public int Votes { get; set; }
    }
}
