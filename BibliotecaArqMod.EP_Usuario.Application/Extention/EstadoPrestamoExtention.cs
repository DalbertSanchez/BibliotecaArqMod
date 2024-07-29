using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Exceptions;
using BibliotecaArqMod.EP_Usuario.Application.Exeptions;


namespace BibliotecaArqMod.EP_Usuario.Application.Extension
{
    public class EstadoPrestamoExtention
    {

        public static void Validar(EstadoPrestamoCreateDto createEstadoPrestamo)
        {
            if (string.IsNullOrEmpty(createEstadoPrestamo.Descripcion))
                throw new EstadoPrestamoServiceException("La descripcion del Estado Prestamo no puede ser nulo");


            if (createEstadoPrestamo.Descripcion.Length > 50)
                throw new EstadoPrestamoServiceException("La descripcion del EstadoPrestamo no puede exceder los 50 caracteres");
        }

        public static void Validar(EstadoPrestamoUpdateDto updateEstadoPrestamo)
        {
            if (updateEstadoPrestamo.Descripcion.Length > 50)
                throw new EstadoPrestamoServiceException("La descripcion del EstadoPrestamo no puede exceder los 50 caracteres");

            if (string.IsNullOrEmpty(updateEstadoPrestamo.Descripcion))
                throw new EstadoPrestamoServiceException("Debes proporcionar todos los campos del Estado Prestamo para poder actualizarlo");
        }

        public static void Validar(EstadoPrestamoDeleteDto deleteEstadoPrestamo)
        {

            if (deleteEstadoPrestamo.Id <= 0)
                throw new EstadoPrestamoServiceException("El ID Estado Prestamo debe ser valido");

        }
    }
}
