using BibliotecaArqMod.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaArqMod.EP_Usuario.Domain.Entities
{
    public class Usuario : AuditEntity<int>
    {
        [Column("idUsuario")]
        public override int Id { get; set; }

        public string? NombreApellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }

        public bool esActivo { get; set; }
        
    }
}
