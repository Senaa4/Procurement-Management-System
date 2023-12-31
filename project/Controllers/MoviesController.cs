﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;
namespace project.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()

        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<customer>
            {
            new customer{ Name="customer 1"},
            new customer{ Name="customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                customers = customers
            }; 
            return View(viewModel);
            //ViewData["RandomMovie"] = movie;

            var viewResult = new ViewResult();
            viewResult.ViewData.Model

            return View(movie);
                //return Content(year + "/" + month);
                // return HttpNotFound();
                //return new EmptyResult();
                // return RedirectToAction("Index","Home",new { page=1, sortBy="name"});
            
           
        }
        
        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            
            return Content(year + "/" + month);
         }  
    }
}