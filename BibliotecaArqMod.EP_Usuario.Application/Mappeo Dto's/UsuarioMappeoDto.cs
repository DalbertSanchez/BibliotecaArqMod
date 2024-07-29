using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;

namespace BibliotecaArqMod.EP_Usuario.Application.Mappeo_Dto_s
{
    public class UsuarioMappeoDto
    {
        public static Usuario ToEntity(UsuarioCreateDto usuarioCreate)
        {
            if (usuarioCreate == null) throw new ArgumentNullException(nameof(usuarioCreate));

            return new Usuario
            {
                NombreApellidos = usuarioCreate.NombreApellidos,
                Correo = usuarioCreate.Correo,
                Clave = usuarioCreate.Clave,
                FechaCreacion = usuarioCreate.FechaCreacion 
            };
        }

        public static UsuarioDtoBase ToModel(Usuario entityUsuario)
        {
            if (entityUsuario == null) throw new ArgumentNullException(nameof(entityUsuario));

            return new UsuarioDtoBase
            {
                Id = entityUsuario.Id,
                NombreApellidos = entityUsuario.NombreApellidos,
                Correo = entityUsuario.Correo,
                Clave = entityUsuario.Clave,
                esActivo = entityUsuario.esActivo,
                FechaCreacion = entityUsuario.FechaCreacion
            };
        }

        public static void UpdateEntityUsuario(UsuarioUpdateDto usuarioUpdate, Usuario entityUsuario)
        {
            if (usuarioUpdate == null) throw new ArgumentNullException(nameof(usuarioUpdate));
            if (entityUsuario == null) throw new ArgumentNullException(nameof(entityUsuario));

            entityUsuario.NombreApellidos = usuarioUpdate.NombreApellidos;
            entityUsuario.Correo = usuarioUpdate.Correo;
            entityUsuario.Clave = usuarioUpdate.Clave;
        }

        public static void DeleteEntityUsuario(UsuarioDeleteDto deleteUsuario, Usuario deleteEntity)
        {
            if (deleteUsuario == null) throw new ArgumentNullException(nameof(deleteUsuario));
            if (deleteEntity == null) throw new ArgumentNullException(nameof(deleteEntity));

            deleteEntity.Id = deleteUsuario.Id;
            deleteEntity.NombreApellidos = deleteUsuario.NombreApellidos;
            deleteEntity.Correo = deleteUsuario.Correo;
            deleteEntity.Clave = deleteUsuario.Clave;
        }
    }

}
