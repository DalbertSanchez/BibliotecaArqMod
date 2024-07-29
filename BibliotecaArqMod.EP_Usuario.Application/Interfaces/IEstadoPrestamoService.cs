using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Persistence.Models;

namespace BibliotecaArqMod.EP_Usuario.Application.Interfaces
{
    public interface IEstadoPrestamoService : IServices<EstadoPrestamoCreateDto, EstadoPrestamoUpdateDto, EstadoPrestamoDeleteDto, EstadoPrestamo>
    {

    }
}
