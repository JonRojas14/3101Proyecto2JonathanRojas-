using Microsoft.AspNetCore.Mvc;
using TestProyecto2.Models;

namespace TestProyecto2.Controllers
{
    public class TransportistaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TransportistaController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<Transportistas> listTransportistas = _context.Transportista;
            return View(listTransportistas);
        }

        public IActionResult RegistrarTransportista()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarTransportista(Transportistas transportistas)
        {

            if (ModelState.IsValid)
            {
                _context.Transportista.Add(transportistas);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
