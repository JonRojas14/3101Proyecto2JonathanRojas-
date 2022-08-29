using System.ComponentModel.DataAnnotations;

namespace TestProyecto2.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el codigo del cliente")]
        [Display(Name = "Codigo de cliente:")]
        [Range(1, 99999, ErrorMessage = "El codigo del cliente tiene como  limite 3 caracteres. Entre 0 y 999.")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre del cliente.")]
        [MaxLength(30, ErrorMessage = "El nombre del cliente puede no puede tener mas de 30 caracteres.")]
        [Display(Name = "Nombre del cliente:")]
        public string NombreCLiente { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero de identificacion del cliente.")]
        [Range(1, 999999999, ErrorMessage = "El numero de identificacion del cliente tiene como  limite 9 digitos.")]
        [Display(Name = "Numero de indetificacion del cliente:")]
        public int Identificacion { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de nacimiento del cliente.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
    }
}
