using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProyecto2.Models
{
    public class ArticulosRetirados
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el codigo del transportista de la lista.")]
        [Display(Name = "Codigo de transportista:")]
        public int CodigoTransportista { get; set; }

        [Required(ErrorMessage = "Debe digitar el Tracking ID del articulo.")]
        [MaxLength(30, ErrorMessage = "El Tracking ID del articulo debe ser de 18 caracteres.")]
        public string TrackingId { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion para el articulo.")]
        [MaxLength(100, ErrorMessage = "La descripcion del articulo no debe ser de mas de 100 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el cliente para el que va drigido el articulo de la lista.")]
        [Display(Name = "Codigo de cliente:")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de retiro del articulo")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Retiro:")]
        public DateTime FechaRetiro { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> CodigoTransportistaReporteRetiro { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> CodigoClienteReporteRetiro { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> TrackingIdArticulosRetiro { get; set; }
    }
}
