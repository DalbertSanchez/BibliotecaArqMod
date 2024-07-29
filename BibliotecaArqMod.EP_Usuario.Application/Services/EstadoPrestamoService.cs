using BibliotecaArqMod.EP_Usuario.Application.Core;
using BibliotecaArqMod.EP_Usuario.Application.Extension;
using BibliotecaArqMod.EP_Usuario.Application.Interfaces;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Mappeo_Dto_s;
using BibliotecaArqMod.EP_Usuario.Application.Exceptions;
using BibliotecaArqMod.EP_Usuario.Application.Exeptions;

namespace BibliotecaArqMod.EP_Usuario.Application.Services
{
    public class EstadoPrestamoService : IEstadoPrestamoService
    {
        private readonly IEstadoPrestamoRepository estadoPrestamoRepository;
        private readonly ILogger<EstadoPrestamoService> logger;

        public EstadoPrestamoService(IEstadoPrestamoRepository estadoPrestamoRepository, ILogger<EstadoPrestamoService> logger)
        {
            this.estadoPrestamoRepository = estadoPrestamoRepository;
            this.logger = logger;
        }

      

        public ServiceResult Create(EstadoPrestamoCreateDto estadoPrestamoCreate)
        {
            
            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                EstadoPrestamoExtention.Validar(estadoPrestamoCreate);

                // Crear el nuevo estado prestamo
                var estadoPrestamo = EstadoPrestamoMappeoDto.ToEntity(estadoPrestamoCreate);
                estadoPrestamoRepository.Create(estadoPrestamo);

            }, logger);


        }

        public ServiceResult Delete(EstadoPrestamoDeleteDto estadoPrestamoDelete)
        {
            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                EstadoPrestamoExtention.Validar(estadoPrestamoDelete);

                // Buscar el estado prestamo
                var estadoPrestamo = estadoPrestamoRepository.GetEntityById(estadoPrestamoDelete.Id);
                if (estadoPrestamo == null)
                {
                    throw new EstadoPrestamoServiceException("Estado Prestamo no encontrado");
                }

                // Eliminar el  estado prestamo
                EstadoPrestamoMappeoDto.DeleteEntityEstadoPrestamo(estadoPrestamoDelete, estadoPrestamo);
                estadoPrestamoDelete.Estado = false;
                estadoPrestamoRepository.Delete(estadoPrestamo);
            }, logger);
        }

        public ServiceResult GetEntity()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = estadoPrestamoRepository.GetAll();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error al obtener los Estados Prestamos" + ex.Message;
            }
            return result;
        }

        public ServiceResult GetEntityByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var estadoPrestamo = this.estadoPrestamoRepository.GetEntityById(id);
                if (estadoPrestamo == null)
                {
                    result.Success = false;
                    result.Message = "Estado Prestamo no encontrado";
                    return result;
                }

                // Mapea la entidad a un DTO
                var estadoPrestamoDto = EstadoPrestamoMappeoDto.ToModel(estadoPrestamo);

                result.Data = estadoPrestamoDto;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo el Estado Prestamo por el ID: " + id;
            }
            return result;
        }

        public ServiceResult Update(EstadoPrestamoUpdateDto estadoPrestamoUpdate)
        {

            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                EstadoPrestamoExtention.Validar(estadoPrestamoUpdate);

                // Buscar el estado prestamo
                var estadoPrestamo = estadoPrestamoRepository.GetEntityById(estadoPrestamoUpdate.Id);
                if (estadoPrestamo == null)
                {
                    throw new EstadoPrestamoServiceException("Estado Prestamo no encontrado");
                }

                // Aplicar las actualizaciones
                EstadoPrestamoMappeoDto.UpdateEntityEstadoPrestamo(estadoPrestamoUpdate, estadoPrestamo);
                estadoPrestamoRepository.Update(estadoPrestamo);


            }, logger); ;
        }
    }
}

