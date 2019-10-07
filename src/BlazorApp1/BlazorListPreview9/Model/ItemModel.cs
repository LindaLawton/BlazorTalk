using System.ComponentModel.DataAnnotations;

namespace BlazorListPreview9.Model
{
    public class ItemModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Range(13, 105, ErrorMessage = "Age invalid (13-105).")]
        public int Age { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "This Form requiers your consent.")]
        public bool HasConsented { get; set; }

    }
}








