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
        public string Book { get; set; }
        [Display(Name = "Chapter/Section")]
        public int ChapterSection { get; set; }
        [Display(Name = "Verse/s")]
        public int Verses { get; set; }
        public string Notes { get; set; }
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }


    }
}
