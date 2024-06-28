
namespace BibliotecaArqMod.Common.Data.Base
{
    /// <summary>
    /// </summary>
    /// <typeparam name="TType"> TType va a recibir el tipo de dato que sea la entidad o modulo </typeparam>
    public abstract class BaseEntity<TType>
    {
        public abstract TType Id { get; set; }
    }
}
