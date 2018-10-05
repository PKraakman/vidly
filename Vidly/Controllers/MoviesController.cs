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
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            //return View(movie);

            //return Content("hoi everyone");
            //return HttpNotFound();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = 2 });
        }

        public ActionResult Edit(int id)
        {
            return Content("MovieId:" + id.ToString());
        }

        private ActionResult Content(string v, int id)
        {
            throw new NotImplementedException();
        }
    }
}