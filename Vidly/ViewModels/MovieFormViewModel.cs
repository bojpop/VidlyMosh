using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date added")]
        [Required]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in stock")]

        [Required]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit movie" : "New movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            DateAdded = movie.DateAdded;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}