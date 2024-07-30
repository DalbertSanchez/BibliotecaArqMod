namespace BibliotecaArqMod.EP_Usuario.Web.Models.UsuarioModel
{
    public class UsuarioGetModel
    {
        public int id { get; set; }
        public string nombreApellidos { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public bool esActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
