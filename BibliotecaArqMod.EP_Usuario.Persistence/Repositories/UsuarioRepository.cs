using System.Linq.Expressions;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Create(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Usuario, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
