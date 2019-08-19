using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class GamesGenreViewModel
    {
        public List<Games> Games { get; set; }
        public SelectList Genres { get; set; }
        public string GamesGenre { get; set; }
        public string SearchString { get; set; }
    }
}
