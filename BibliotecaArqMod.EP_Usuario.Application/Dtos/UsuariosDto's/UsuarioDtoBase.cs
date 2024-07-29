using BibliotecaArqMod.Common.Data.Base;

namespace BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s
{
    public class UsuarioDtoBase : AuditEntity<int>
    {
        public override int Id { get; set; }
        public string? NombreApellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public bool esActivo { get; set; }
    }
}
