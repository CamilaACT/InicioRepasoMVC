using System.ComponentModel.DataAnnotations;

namespace BlogCore.Models
{
    public class Contacto
    {
        //con prop se crea autoamatico
        [Key]//DATA NOTATION es una llave primaria
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]// DATA NOTATION que hace que el campo sea obligatorio
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public int Email { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
