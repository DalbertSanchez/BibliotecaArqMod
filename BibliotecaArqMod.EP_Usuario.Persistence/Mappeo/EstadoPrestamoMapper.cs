using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Mappeo
{
    public class EstadoPrestamoMapper
    {
        /*ToEntity(CreateEstadoPrestamoModel modelEstadoPrestamo)
       Convierte un modelo CreateEstadoPrestamoModel a una entidad EstadoPrestamo*/
        public static EstadoPrestamo ToEntity(EstadoPrestamo entity)
        {
            return new EstadoPrestamo
            {
                Descripcion = entity.Descripcion,
                Estado = entity.Estado,
                FechaCreacion = entity.FechaCreacion,

            };
        }

        /*ToModel(EstadoPrestamo entityEstadoPrestamo)
         Convierte una entidad EstadoPrestamo a un modelo EstadoPrestamoModel*/
        public static EstadoPrestamo ToModel(EstadoPrestamo entityEstadoPrestamo)
        {
            return new EstadoPrestamo
            {
                Id = entityEstadoPrestamo.Id,
                Descripcion = entityEstadoPrestamo.Descripcion,
                Estado = entityEstadoPrestamo.Estado,
                FechaCreacion = entityEstadoPrestamo.FechaCreacion
            };
        }

        /*UpdateEntityEstadoPrestamo(UpdateEstadoPrestamoModel updateModel, EstadoPrestamo updateEntity)
         Actualiza una entidad EstadoPrestamo existente con los datos 
         proporcionados en un UpdateEstadoPrestamoModel*/
        public static void UpdateEntityEstadoPrestamo(EstadoPrestamo updateModel, EstadoPrestamo updateEntity)
        {
            updateEntity.Descripcion = updateModel.Descripcion;
            updateEntity.Estado = updateModel.Estado;

        }

        /*DeleteEntityEstadoPrestamo(DeleteEstadoPrestamoModel deleteModel, EstadoPrestamo deleteEntity)
         Elimina una entidad EstadoPrestamo existente con los datos 
         proporcionados en un DeleteEstadoPrestamoModel */
        public static void DeleteEntityEstadoPrestamo(EstadoPrestamo deleteModel, EstadoPrestamo deleteEntity)
        {
            deleteEntity.Id = deleteModel.Id;
            deleteEntity.Descripcion = deleteModel.Descripcion;
            deleteEntity.Estado = deleteModel.Estado;

        }
    }
}
