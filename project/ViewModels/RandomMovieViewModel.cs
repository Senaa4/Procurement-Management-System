using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project.Models;
namespace project.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<customer> customers { get; set; }

    }
}