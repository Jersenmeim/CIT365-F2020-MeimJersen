using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class scriptures
    {
        [Key]
        public int Scriptureid { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Book { get; set; }

        [Range(1, 150)]
        [StringLength(3, MinimumLength = 3)]
        [Display(Name = "Chapter/Section")]
        public int ChapterSection { get; set; }
        [Display(Name = "Verse/s")]
        [Range(1, 150)]
        public int Verses { get; set; }

        [StringLength(500, MinimumLength = 3)]
        public string Notes { get; set; }
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }


    }
}
