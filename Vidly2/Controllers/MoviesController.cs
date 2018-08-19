using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        //private List<Customer> customers;

        //// GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customers = new List<Customer>()
        //    {
        //        new Customer {Name = "customer 1" },
        //        new Customer {Name = "customer 2" }

        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}

        //public ActionResult Edit(int Id)
        //{
        //    return Content("id = " + Id);
        //}

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}||\\d{1}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var viewModel = new IndexMovieViewModel();

            viewModel.ListOfMovies = new List<Movie>()
            {
                new Movie { Id = 1, Name = "Shrek1", ReleaseYear = 2013, ReleaseMonth = 3 },
                new Movie { Id = 2, Name = "Shrek2", ReleaseYear = 2014, ReleaseMonth = 5 }
            };


                return View(viewModel);
            
            
        }

        //public ActionResult Index(int? PageIndex, string SortBy)
        //{
        //    if (!PageIndex.HasValue)
        //        PageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(SortBy))
        //        SortBy = "Name";

        //    return Content(String.Format("PageIndex={0}&SortBy={1}", PageIndex, SortBy));
        //}

        
    }
}