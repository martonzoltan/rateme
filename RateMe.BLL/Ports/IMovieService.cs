using RateMe.Core.Models;
using RateMe.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.BLL.Ports
{
    public interface IMovieService
    {
        void Save(Movie task);
    }
}
