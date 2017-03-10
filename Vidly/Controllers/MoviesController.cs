using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie=new Movie(){Name = "Zukerface"};
            var customers=new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"},
                new Customer {Name = "Customer3"},
                new Customer {Name = "Customer5"},
                new Customer {Name = "Customer4"}
            };
            var viewModel=new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;
            return View(viewModel);
            
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        public ActionResult Index()
        {
            var movies=new List<Movie>
            {
                new Movie {Id = 1,Name = "Jobs"},
                new Movie {Id = 2,Name = "Seabiscuit"},
                new Movie {Id = 3,Name = "The Pursuit of Happyness "},
                new Movie {Id = 4,Name = "Moneyball "},
                new Movie {Id = 5,Name = "Any Given Sunday"},
                new Movie {Id = 6,Name = "Draft Day"},
                new Movie {Id = 7,Name = "Ronin"}
            };
            var movieList=new MovieViewModel();
            movieList.Movies = movies;
            return View(movieList);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content($"{year}/{month}");
        }
    }
}