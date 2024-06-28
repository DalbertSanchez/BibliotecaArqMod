using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        #region"DbSet"
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<EstadoPrestamo> EstadoPrestamo { get; set; }

        #endregion
    }
}
