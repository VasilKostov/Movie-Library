﻿using MovieLibrary.Models.Actors;
using MovieLibrary.Models.Movies;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace MovieLibrary.Models.Relations
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
    }
}
