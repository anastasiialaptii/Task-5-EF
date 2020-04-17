using System.ComponentModel.DataAnnotations;

namespace Task5_EF.Models
{
    public class StatusModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
    }
}