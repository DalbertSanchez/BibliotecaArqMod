using System.Linq.Expressions;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;
using BibliotecaArqMod.EP_Usuario.Persistence.Context;
using BibliotecaArqMod.EP_Usuario.Persistence.Mappeo;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Repositories
{
    /// <summary>
    /// Objetos de los DbObjects
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly BibliotecaContext context;

        public UsuarioRepository(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Create(Usuario entity)
        {
            var usuario = UsuarioMapper.ToEntity(entity);
            usuario.esActivo = true;
            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void Delete(Usuario entity)
        {
            Usuario usuarioToDelete = this.context.Usuario.Find(entity.Id);

            if (usuarioToDelete == null)
            {
                throw new ArgumentException("Usuario no encontrado");
            }

            // Utilizar el método DeleteEntityUsuario para eliminar la entidad con los datos de eliminación
            UsuarioMapper.DeleteEntityUsuario(entity, usuarioToDelete);

            // Actualizar la entidad en el contexto y guardar los cambios en la base de datos
            usuarioToDelete.esActivo = false;
            this.context.Usuario.Remove(usuarioToDelete);
            this.context.SaveChanges();
        }

        public bool Exists(Expression<Func<Usuario, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            return this.context.Usuario.Select(UsuarioMapper.ToModel).ToList();
        }

        public Usuario GetEntityById(int Id)
        {
            var usuario = this.context.Usuario.Find(Id);

            return UsuarioMapper.ToModel(usuario);
        }

        public void Update(Usuario entity)
        {
            Usuario usuarioToUpdate = this.context.Usuario.Find(entity.Id);
            UsuarioMapper.UpdateEntityUsuario(entity, usuarioToUpdate);

            this.context.Usuario.Update(usuarioToUpdate);
            this.context.SaveChanges();
        }
    }
}
