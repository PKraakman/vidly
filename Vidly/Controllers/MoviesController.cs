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
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 11"},
                new Customer {Name = "Customer 22"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return Content("hoi everyone");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = 2 });
        }

        public ActionResult Edit(int id)
        {
            return Content("MovieId:" + id.ToString());
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("Showing page {0}, sorted by {1}", pageIndex, sortBy));
        }


        [Route("movies/released/{year:regex(2017|2018)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("Movies Released Since {0} / {1}", month, year));
        }


    }
}