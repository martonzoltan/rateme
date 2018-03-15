using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMe.UI.Models
{
    public class MovieModel
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Runtime")]
        [Display(Name = "Runtime")]
        [MaxLength(7)]
        public string Runtime { get; set; }

        [Required(ErrorMessage = "Please Enter ReleaseDate")]
        [Display(Name = "ReleaseDate")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please Enter Genres")]
        [Display(Name = "Genres")]
        [MinLength(5), MaxLength(30)]
        [DataType(DataType.Text)]
        public string Genres { get; set; }

        public int Votes { get; set; }
    }
}
