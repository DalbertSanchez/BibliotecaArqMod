using BibliotecaArqMod.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaArqMod.EP_Usuario.Domain.Entities
{
    public class EstadoPrestamo : AuditEntity<int>
    {
        [Column("IdEstadoPrestamo")]
        public override int Id { get; set; }
    }
}
