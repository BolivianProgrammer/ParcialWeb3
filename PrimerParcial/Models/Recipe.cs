using System;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int PreparationTimeMinutes { get; set; }

        [Required]
        public int Servings { get; set; }

        [Required]
        public string Instructions { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}