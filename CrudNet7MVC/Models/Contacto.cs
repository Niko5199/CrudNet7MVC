using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The movil is required")]
        public string Movil { get; set; }

        [Required(ErrorMessage = "The email is required")]
        public string Email { get; set; }

        public DateTime Created_At { get; set; }
    }
}
