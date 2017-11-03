using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Coustomer> Coustomers { get; set; }
    }
}