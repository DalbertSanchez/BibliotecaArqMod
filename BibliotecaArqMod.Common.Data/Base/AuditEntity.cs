
namespace BibliotecaArqMod.Common.Data.Base
{
    /// <summary>
    /// 
    /// En esta clase iran los campos de auditoria que seran comunes entre nuestras entidades
    /// en este caso solo tenemos unos un solo campo que es FechaCreacion
    /// 
    /// </summary>

    public abstract class AuditEntity<TType> : BaseEntity<TType>
    {
        protected AuditEntity()
        {
            this.FechaCreacion = DateTime.Now;
        }
        public DateTime FechaCreacion { get; set; }
    }
}
