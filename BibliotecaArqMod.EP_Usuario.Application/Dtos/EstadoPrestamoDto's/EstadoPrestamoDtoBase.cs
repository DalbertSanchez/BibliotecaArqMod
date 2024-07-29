using BibliotecaArqMod.Common.Data.Base;

namespace BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s
{
    public class EstadoPrestamoDtoBase : AuditEntity<int>
    {

        public override int Id { get; set ; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }

    }
}
