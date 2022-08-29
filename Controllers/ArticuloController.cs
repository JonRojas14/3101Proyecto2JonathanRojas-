using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestProyecto2.Models;

namespace TestProyecto2.Controllers
{
    public class ArticuloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticuloController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET lista de articulos en custodia
        public IActionResult Index()
        {
            IEnumerable<ArticulosCustodia> listArticulos = _context.ArticuloCustodia;
            return View(listArticulos);
        }

        // GET obtiene el formulario para registrar articulos
        public IActionResult RegistrarIngreso()
        {
            var vm = new ArticulosCustodia();

            vm.CodigoTransportistaReporte = _context.Transportista.Select(x => new SelectListItem() { Value = x.Código.ToString(), Text = x.Código.ToString() }).ToList();
            vm.CodigoClienteReporte = _context.Cliente.Select(x => new SelectListItem() { Value = x.CodigoCliente.ToString(), Text = x.CodigoCliente.ToString() }).ToList();

            return View(vm);
        }

        // POST para registrar articulos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarIngreso(ArticulosCustodia articulos)
        {
            _context.ArticuloCustodia.Add(articulos);
            _context.SaveChanges();

            return RedirectToAction("Index");

            return View(articulos);
        }

        // GET formulario para editar el estado del articulo
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }


            //obtener el registro del articulo en custodia
            var cita = _context.ArticuloCustodia.Find(id);

            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);

        }

        //POST Edit Lista Ingresos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ArticulosCustodia articulocust)
        {
            _context.ArticuloCustodia.Update(articulocust);
            _context.SaveChanges();

            return RedirectToAction("Index");
           

            return View();
        }

        // GET lista de articulos retirados
        public IActionResult IndexRetiros()
        {
            IEnumerable<ArticulosRetirados> listRetiros = _context.ArticuloRetirado;
            return View(listRetiros);
        }

        // GET fomulario para registrar un retiro de articulos
        public IActionResult RegistrarRetiro()
        {
            var vm = new ArticulosRetirados();

            vm.CodigoTransportistaReporteRetiro = _context.Transportista.Select(x => new SelectListItem() { Value = x.Código.ToString(), Text = x.Código.ToString() }).ToList();
            vm.CodigoClienteReporteRetiro = _context.Cliente.Select(x => new SelectListItem() { Value = x.CodigoCliente.ToString(), Text = x.CodigoCliente.ToString() }).ToList();
            vm.TrackingIdArticulosRetiro = _context.ArticuloCustodia.Select(x => new SelectListItem() { Value = x.TrackingId, Text = x.TrackingId }).ToList();

            return View(vm);
        }
         //POST para registrar el retiro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarRetiro(ArticulosRetirados articulosR)
        {
            _context.ArticuloRetirado.Add(articulosR);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

            return View(articulosR);
        }

    }
}
