using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;

namespace BibliotecaArqMod.EP_Usuario.Application.Mappeo_Dto_s
{
    public class EstadoPrestamoMappeoDto
    {
       
        public static EstadoPrestamo ToEntity(EstadoPrestamoCreateDto estadoPrestamoCreate)
        {
            if (estadoPrestamoCreate == null) throw new ArgumentNullException(nameof(estadoPrestamoCreate));

            return new EstadoPrestamo
            {
                Descripcion = estadoPrestamoCreate.Descripcion,
                Estado = estadoPrestamoCreate.Estado,
                FechaCreacion = estadoPrestamoCreate.FechaCreacion,

            };
        }

     
        public static EstadoPrestamoDtoBase ToModel(EstadoPrestamo entityEstadoPrestamo)
        {
            if (entityEstadoPrestamo == null) throw new ArgumentNullException(nameof(entityEstadoPrestamo));

            return new EstadoPrestamoDtoBase
            {
                Id = entityEstadoPrestamo.Id,
                Descripcion = entityEstadoPrestamo.Descripcion,
                Estado = entityEstadoPrestamo.Estado,
                FechaCreacion = entityEstadoPrestamo.FechaCreacion
            };
        }

      
        public static void UpdateEntityEstadoPrestamo(EstadoPrestamoUpdateDto estadoPrestamoUpdate, EstadoPrestamo updateEstadoPrestamo)
        {
            if (updateEstadoPrestamo == null) throw new ArgumentNullException(nameof(updateEstadoPrestamo));
            if (estadoPrestamoUpdate == null) throw new ArgumentNullException(nameof(estadoPrestamoUpdate));

            updateEstadoPrestamo.Descripcion = estadoPrestamoUpdate.Descripcion;
            updateEstadoPrestamo.Estado = estadoPrestamoUpdate.Estado;

        }

       
        public static void DeleteEntityEstadoPrestamo(EstadoPrestamoDeleteDto estadoPrestamoDelete, EstadoPrestamo deleteEstadoPrestamo)
        {
            if (deleteEstadoPrestamo == null) throw new ArgumentNullException(nameof(deleteEstadoPrestamo));
            if (estadoPrestamoDelete == null) throw new ArgumentNullException(nameof(estadoPrestamoDelete));

            deleteEstadoPrestamo.Id = estadoPrestamoDelete.Id;
            deleteEstadoPrestamo.Descripcion = estadoPrestamoDelete.Descripcion;
            deleteEstadoPrestamo.Estado = estadoPrestamoDelete.Estado;

        }
    }
}
