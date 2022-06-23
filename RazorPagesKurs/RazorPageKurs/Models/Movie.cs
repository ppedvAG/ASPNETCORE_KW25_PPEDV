using System.ComponentModel.DataAnnotations;

namespace RazorPageKurs.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Range(0.1, 100)]
        public decimal Price { get; set; }

        [Range(0.1, 10)]
        [Display(Name = "IMDB Rating")]
        public double IMDBRating { get; set; }

        [Required]
        public GenreType Genre { get; set; }
    }

    public enum GenreType { Action, Thriller, Comedy, Romance, Drama, Horror, Animations, ScienceFiction, Adventure, Biography, History, Docu}
}
