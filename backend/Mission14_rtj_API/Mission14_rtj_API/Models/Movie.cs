using System;
using System.ComponentModel.DataAnnotations;

namespace Mission14_rtj_API.Models
{
	public class Movie
	{
        //Creating model based off of database
        [Key]
        public int MovieId { get; set; }
        public string? Category { get; set; }

        public string? Title { get; set; }
        public int? Year { get; set; }
        public string? Director { get; set; }

        public string? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }

    }
}

