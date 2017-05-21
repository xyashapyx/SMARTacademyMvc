using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMARTacademyMvc.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Remote(action: "VerifyTitle", controller: "Validation")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [ClassicMovie(1960)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public bool Preorder { get; set; }
    }

    class ClassicMovieAttribute : ValidationAttribute
    {
        private int _year;

        public ClassicMovieAttribute(int Year)
        {
            _year = Year;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Movie movie = (Movie)validationContext.ObjectInstance;

            if (movie.Genre == Genre.Classic && movie.ReleaseDate.Year > _year)
            {
                return new ValidationResult(
                    "Classic movies must have a release year earlier than " + _year,
                    new[] { "ReleaseDate" });
            }

            return ValidationResult.Success;
        }
    }

    public enum Genre
    {
        Classic,
        Action,
        Comedy,
        Drama,
        Horror
    }
}