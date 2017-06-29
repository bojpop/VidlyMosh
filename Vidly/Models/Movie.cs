using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId {get; set;}
        
        [Display(Name = "Release date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Date added")]
        [Required]
        public DateTime? DateAdded { get; set; }
        
        [Display(Name = "Number in stock")]

        [Required]
        [Range(1,20)]
        public int NumberInStock { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}