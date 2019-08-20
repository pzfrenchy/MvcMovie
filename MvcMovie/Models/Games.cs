﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Games
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date")]
        public DateTime ReleaseDate { get; set; }
        [StringLength(20)]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
