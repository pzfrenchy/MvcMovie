﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Games
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [StringLength(20)]
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
