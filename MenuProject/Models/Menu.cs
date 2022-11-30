using System.ComponentModel.DataAnnotations;

namespace MenuProject.Models
{
    public class Menu
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Price { get; set; }

        public string? Image { get; set; }

        [Timestamp]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
    }
}
