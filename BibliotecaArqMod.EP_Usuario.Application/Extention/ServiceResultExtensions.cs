using BibliotecaArqMod.EP_Usuario.Application.Core;
using BibliotecaArqMod.EP_Usuario.Application.Exceptions;
using BibliotecaArqMod.EP_Usuario.Application.Exeptions;
using Microsoft.Extensions.Logging;

namespace BibliotecaArqMod.EP_Usuario.Application.Extension
{
    public static class ServiceResultExtensions
    {
        public static ServiceResult ExecuteWithHandling(this ServiceResult result, Action action, ILogger log)
        {
            try
            {
                action();
                result.Success = true;
                
            }
            catch (UsuarioServiceException ex)
            {
                log.LogError(ex.Message);
                result.Success = false;
                result.Message = ex.Message;
            }
            catch (EstadoPrestamoServiceException ex)
            {
                log.LogError(ex.Message);
                result.Success = false;
                result.Message = ex.Message;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                result.Success = false;
                result.Message = "Ocurrió un error procesando la solicitud.";
            }
            return result;
        }
    }
}
