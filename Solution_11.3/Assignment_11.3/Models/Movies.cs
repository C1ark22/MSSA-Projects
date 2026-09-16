using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11._3.Models
{
    public class Movies
    {
        public int MovieId { get; set; }

        public string Title { get; set; } = "";

        public int ReleaseYear { get; set; }

        // The ID of this movie's genre
        public int GenreId { get; set; }

        // The genre object this movie belongs to
        public virtual Movies_Genre Genre { get; set; } = null!;
    }
}
