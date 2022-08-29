using Microsoft.EntityFrameworkCore;
using TestProyecto2.Models;

namespace TestProyecto2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Constructor de la clase
        }

        //Instacias de los modelos
        public DbSet<Transportistas> Transportista { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<ArticulosCustodia> ArticuloCustodia { get; set; }
        public DbSet<ArticulosRetirados> ArticuloRetirado { get; set; }
    }
}
