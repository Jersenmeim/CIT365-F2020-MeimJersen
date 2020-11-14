using Microsoft.AspNetCore.Http;
//using MvcMovie.Migrations;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieEditViewModel : Movie
    {
        [Key]
        public int MovieId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public new string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public new DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }

        [Display(Name = "Genre")]
        public new int GenreID { get; set; }
        [Display(Name = "Genre")]
        public new Genre Genre { get; set; }

        [Required]
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public new decimal Price { get; set; }

        public IFormFile Photo { get; set; }

        public string ExistingPhoto { get; set; }
    }
}
