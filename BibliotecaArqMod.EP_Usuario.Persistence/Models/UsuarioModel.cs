namespace BibliotecaArqMod.EP_Usuario.Persistence.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? NombreApellidos { get; set; }
        public string? Correo { get; set; }
        public bool? esActivo { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
