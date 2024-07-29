using BibliotecaArqMod.EP_Usuario.Domain.Entities;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Mappeo
{
    public class UsuarioMapper
    {
      
        /* ToEntity(CreateUsuarioModel modelUsuario)
      Convierte un modelo CreateUsuarioModel a una entidad Usuario*/
        public static Usuario ToEntity(Usuario entity)
        {
            return new Usuario
            {
                Id = entity.Id,
                NombreApellidos = entity.NombreApellidos,
                Correo = entity.Correo,
                Clave = entity.Clave,
                FechaCreacion = entity.FechaCreacion

            };
        }


        /* ToModel(Usuario entityUsuario)
       Convierte una entidad Usuario a un modelo CreateUsuarioModel*/
        public static Usuario ToModel(Usuario entityUsuario)
        {
            if (entityUsuario == null) throw new ArgumentNullException(nameof(entityUsuario));

            return new Usuario
            {
                Id = entityUsuario.Id,
                NombreApellidos = entityUsuario.NombreApellidos,
                Correo = entityUsuario.Correo,
                esActivo = entityUsuario.esActivo,
                Clave = entityUsuario.Clave,
                FechaCreacion = entityUsuario.FechaCreacion
            };
        }


        ///*UpdateEntityUsuario(UpdateUsuarioModel modelUsuario,Usuario entityUsuario) 
        // Actualiza una entidad Usuario existente con los datos 
        // proporcionados en un UpdateUsuarioModel*/
        public static void UpdateEntityUsuario(Usuario entityUsuario, Usuario usuarioToUpdate)
        {
            if (usuarioToUpdate == null) throw new ArgumentNullException(nameof(usuarioToUpdate));

            // Actualizar la entidad con los datos del modelo
            usuarioToUpdate.NombreApellidos = entityUsuario.NombreApellidos;
            usuarioToUpdate.Correo = entityUsuario.Correo;
            usuarioToUpdate.Clave = entityUsuario.Clave;
        }





        /* DeleteEntityUsuario(DeleteUsuarioModel deleteModel, Usuario deleteEntity)
         Elimina una entidad Usuario existente con los datos 
         proporcionados en un DeleteUsuarioModel */
        public static void DeleteEntityUsuario(Usuario usuarioToDelete, Usuario deleteEntity)
        {

            usuarioToDelete.Id = deleteEntity.Id;
            usuarioToDelete.NombreApellidos = deleteEntity.NombreApellidos;
            usuarioToDelete.Correo = deleteEntity.Correo;
            usuarioToDelete.Clave = deleteEntity.Clave;
        }
    }
}
