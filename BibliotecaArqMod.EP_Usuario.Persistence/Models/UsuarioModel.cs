
namespace BibliotecaArqMod.EP_Usuario.Persistence.Models
{
    public class UsuarioModel: BaseModel
    {
        //Atributos de la entidad Usuario
        public string? NombreApellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public bool esActivo { get; set; }
    }
}
