using System.ComponentModel.DataAnnotations;

namespace MenuProject.Dtos
{
    public class MenuCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Price { get; set; }

        public string? Image { get; set; }
    }
}
