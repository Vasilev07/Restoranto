﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Resturanto.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

        public ICollection<Table> Tables { get; set; } = new List<Table>();
    }
}