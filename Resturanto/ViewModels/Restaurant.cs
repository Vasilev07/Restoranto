using Resturanto.Models;
using System.ComponentModel.DataAnnotations;

namespace Resturanto.ViewModels
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

        public int Tables { get; set; }
    }
}