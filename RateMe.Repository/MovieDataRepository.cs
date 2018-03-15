using RateMe.Repository.Entity;
using RateMe.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.Repository
{
    public class MovieDataRepository : Repository<MovieDataEntity>
    {
        public MovieDataEntity GetMovieDataById(int id)
        {
            return GetById(id);
        }
    }
}
