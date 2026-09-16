using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_11._3.Models
{
    public class Movies_Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string GenreName { get; set; } = "";

        // All movies that belong to this genre
        public virtual ObservableCollectionListSource<Movies> Movies { get; }
            = new ObservableCollectionListSource<Movies>();
    }
}
