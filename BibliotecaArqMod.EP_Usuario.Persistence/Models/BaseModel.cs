
using BibliotecaArqMod.Common.Data.Base;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Models
{
    public class BaseModel: AuditEntity<int>
    {
        //Id generico para ambas entidades
        public override int Id { get; set; }

    }
}
