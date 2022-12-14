using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Movie
    {
        [Display(Name="Movie Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Year of Release")]
        public int Year { get; set; }
        [Display(Name="Viewers Choice")]
        public int Rating { get; set; }
    }
}
