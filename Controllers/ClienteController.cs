using Microsoft.AspNetCore.Mvc;
using TestProyecto2.Models;

namespace TestProyecto2.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<Clientes> listClientes = _context.Cliente;
            return View(listClientes);
        }

        public IActionResult RegistrarCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarCliente(Clientes clientes)
        {

            if (ModelState.IsValid)
            {
                _context.Cliente.Add(clientes);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
