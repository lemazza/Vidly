using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Golden Eye" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Bob Newhart" },
                new Customer {Name = "Tony Danza"},
                new Customer {Name = "Melissa Joan Hart"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Golden Eye", Id = 1 },
                new Movie {Name = "Magnolia", Id = 2 },
                new Movie {Name = "Faster and Furiouser", Id = 3},
            };

            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}:range(1,12))}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}