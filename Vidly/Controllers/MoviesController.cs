using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shark"};

            //return View(movie);
            //return Content("Hellow World");
            //return HttpNotFound();
            //ViewData["Movie"] = movie;
            var coustomers = new List<Coustomer>
            {
                new Coustomer {Name="Coustomer 1"},
                new Coustomer {Name="Coustomer 2"}

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Coustomers = coustomers
            };

            return View(viewModel);

        }
        [Route("movies/edit/{id}")]
        public ActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content("year: " + year+"Month: "+month);
        }
    }
}