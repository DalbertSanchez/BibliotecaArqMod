using BibliotecaArqMod.Common.Data.Repository;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;


namespace BibliotecaArqMod.EP_Usuario.Domain.Interfaces
{
    /// <summary>
    /// 
    /// En esta interfaz heredamos los metodos del CRUD que tenemos en el IBaseRepository
    /// 
    /// </summary>
    public interface IUsuarioRepository : IBaseRepository<Usuario, int>
    {
        
    }
}
