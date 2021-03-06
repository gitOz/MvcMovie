﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        /// <summary>
        /// Added Part 10
        /// The Movie class to take advantage of the built-in Required, StringLength,  
        /// RegularExpression, and Range validation attributes.
        /// </summary>
        public int ID { get; set; }
        [StringLength( 60, MinimumLength = 3 )]
        public string Title { get; set; }

        [Display( Name = "Release Date" )]
        [DataType( DataType.Date )]
        [DisplayFormat( DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true )]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression( @"^[A-Z]+[a-zA-Z''-'\s]*$" )]
        [Required]
        [StringLength( 30 )]
        public string Genre { get; set; }

        [Range( 1, 100 )]
        [DataType( DataType.Currency )]
        public decimal Price { get; set; }

        [RegularExpression( @"^[A-Z]+[a-zA-Z''-'\s]*$" )]
        [StringLength( 5 )]
        public string Rating { get; set; }//added part in part 9

        public string Reviews { get; set; }//added another property
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}