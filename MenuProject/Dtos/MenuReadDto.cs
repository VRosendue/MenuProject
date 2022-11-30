using System.ComponentModel.DataAnnotations;

namespace MenuProject.Dtos
{
    public class MenuReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Price { get; set; }

        public string? Image { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
