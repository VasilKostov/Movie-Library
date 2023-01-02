﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieLibrary.ViewModels.MovieViewModels.CreateMovie
{
    public class ActorsMovieDropDownViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public List<SelectListItem> AllActors { get; set; }
    }
}
