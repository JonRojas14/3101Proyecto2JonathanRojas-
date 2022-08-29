using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProyecto2.Models
{
    public class ArticulosCustodia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el codigo del transportista de la lista.")]
        [Display(Name = "Codigo de transportista:")]
        public int CodigoTransportista { get; set; }

        [Required(ErrorMessage = "Debe digitar el Tracking ID del articulo.")]
        [MaxLength(30, ErrorMessage = "El Tracking ID del articulo debe ser de 18 caracteres.")]
        [Display(Name = "Tracking ID del articulo:")]
        public string TrackingId { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion para el articulo.")]
        [MaxLength(100, ErrorMessage = "La descripcion del articulo no debe ser de mas de 100 caracteres.")]
        [Display(Name = "Descripcion del articulo:")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso del articulo.")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "El peso del ariculo debe incluir decimales.")]
        [Display(Name = "Peso del articulo:")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Debe ingresar el precio del articulo.")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Precio invalido: debe incluir  2 decimales.")]
        [Display(Name = "Precio del articulo:")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el cliente para el que va drigido el articulo de la lista.")]
        [Display(Name = "Codigo de cliente:")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de ingreso del articulo")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso:")]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Estado del articulo:")]
        public string? Estado { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> CodigoTransportistaReporte { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> CodigoClienteReporte { get; set; }


    }
}
