
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;


namespace BibliotecaArqMod.EP_Usuario.Application.Interfaces
{
    public interface IUsuarioService : IServices<UsuarioCreateDto, UsuarioUpdateDto, UsuarioDeleteDto ,Usuario>
    {
        
        
    }
}
