using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Exceptions;


namespace BibliotecaArqMod.EP_Usuario.Application.Extention
{
    public class UsuarioExtention
    {
        public static void Validar(UsuarioCreateDto createUsuario)
        {

            if (string.IsNullOrEmpty(createUsuario.NombreApellidos))
                throw new UsuarioServiceException("El usuario no puede ser nulo");


            if (createUsuario.NombreApellidos.Length > 100)
                throw new UsuarioServiceException("El nombre del usuario no puede exceder los 100 caracteres");
        }

        public static void Validar(UsuarioUpdateDto updateUsuarioModel)
        {
            if (string.IsNullOrEmpty(updateUsuarioModel.NombreApellidos))
                throw new UsuarioServiceException("El nombre del usuario no puede ser nulo");


            if (updateUsuarioModel.NombreApellidos.Length > 100)
                throw new UsuarioServiceException("El nombre del usuario no puede exceder los 100 caracteres");
        }

        public static void Validar(UsuarioDeleteDto deleteUsuario)
        {

            if (deleteUsuario.Id <= 0)
                throw new UsuarioServiceException("El ID Estado Prestamo debe ser valido");

        }
    }
}
