namespace BibliotecaArqMod.EP_Usuario.Web.Models.EstadoPrestamoModel
{
    public class EstadoPrestamoCreateModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
