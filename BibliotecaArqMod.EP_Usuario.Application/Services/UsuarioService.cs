using BibliotecaArqMod.EP_Usuario.Application.Core;
using BibliotecaArqMod.EP_Usuario.Application.Extension;
using BibliotecaArqMod.EP_Usuario.Application.Interfaces;
using BibliotecaArqMod.EP_Usuario.Application.Extention;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Mappeo_Dto_s;
using BibliotecaArqMod.EP_Usuario.Application.Exceptions;

namespace BibliotecaArqMod.EP_Usuario.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly ILogger<UsuarioService> logger;

        public UsuarioService(IUsuarioRepository usuarioRepository, ILogger<UsuarioService> logger)
        {
            this.usuarioRepository = usuarioRepository;
            this.logger = logger;
        }

        public ServiceResult Create(UsuarioCreateDto usuarioCreate)
        {
            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                UsuarioExtention.Validar(usuarioCreate);

                // Crear el nuevo usuario
                var nuevoUsuario = UsuarioMappeoDto.ToEntity(usuarioCreate);
                usuarioRepository.Create(nuevoUsuario);

            }, logger);
        }

        public ServiceResult Delete(UsuarioDeleteDto usuarioDelete)
        {
            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                UsuarioExtention.Validar(usuarioDelete);

                // Buscar el usuario
                var usuario = usuarioRepository.GetEntityById(usuarioDelete.Id);
                if (usuario == null)
                {
                    throw new UsuarioServiceException("Usuario no encontrado");
                }

                // Eliminar el usuario
                UsuarioMappeoDto.DeleteEntityUsuario(usuarioDelete, usuario);
                usuarioDelete.esActivo = false;
                usuarioRepository.Delete(usuario);
            }, logger);
        }


        public ServiceResult GetEntity()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = usuarioRepository.GetAll();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error al obtener los usuarios: " + ex.Message;
            }
            return result;
        }


        public ServiceResult GetEntityByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var usuario = this.usuarioRepository.GetEntityById(id);
                if (usuario == null)
                {
                    result.Success = false;
                    result.Message = "Usuario no encontrado";
                    return result;
                }

                // Mapea la entidad a un DTO
                var usuarioDto = UsuarioMappeoDto.ToModel(usuario);

                result.Data = usuarioDto;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo el usuario por el ID: " + id;
            }
            return result;
        }

      

        public ServiceResult Update(UsuarioUpdateDto usuarioUpdate)
        {
            return new ServiceResult().ExecuteWithHandling(() =>
            {
                // Validar el DTO
                UsuarioExtention.Validar(usuarioUpdate);

                // Buscar el usuario
                var usuario = usuarioRepository.GetEntityById(usuarioUpdate.Id);
                if (usuario == null)
                {
                    throw new UsuarioServiceException("Usuario no encontrado");
                }

                // Aplicar las actualizaciones
                UsuarioMappeoDto.UpdateEntityUsuario(usuarioUpdate, usuario);
                usuarioRepository.Update(usuario);

                
            }, logger);
        }

    }

}