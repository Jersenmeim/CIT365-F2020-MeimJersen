using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        [Required]
        public string Details { get; set; }
    }
}
