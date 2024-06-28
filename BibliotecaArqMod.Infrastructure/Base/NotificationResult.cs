
namespace BibliotecaArqMod.Infrastructure.Base
{
    /// <summary>
    /// Esta clase es la que se va a encargar de enviar una notificaciones para saber si el proceso
    /// se completo satisfactoriamente o no 
    /// </summary>
    public class NotificationResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}
