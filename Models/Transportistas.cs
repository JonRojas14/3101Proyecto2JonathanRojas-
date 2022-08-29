using System.ComponentModel.DataAnnotations;

namespace TestProyecto2.Models
{
    public class Transportistas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el codigo de transportista.")]
        [Display(Name = "Codigo de transportista:")]
        [Range(1, 999, ErrorMessage = "El codigo de transportista tiene como  limite 3 caracteres. Entre 0 y 999.")]
        public int Código { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre de la empresa para la que trabaja el transportista.")]
        [Display(Name = "Nombre de la empresa:")]
        [MaxLength(30, ErrorMessage =  "El nombre de la empresa puede no puede tener mas de 30 caracteres.")]
        public string NombreEmpresa { get; set; }
    }
}
