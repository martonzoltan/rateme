using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.Repository.Entity
{
    [Table("dbo.Rating")]
    public class RatingEntity
    {
        [Key]
        public int RatingID { get; set; }

        public int RatingIMDB { get; set; }

        public int RatingMetascore { get; set; }
    }
}
    
        

