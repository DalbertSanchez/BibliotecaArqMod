namespace BibliotecaArqMod.EP_Usuario.Persistence.Models
{
    public class EstadoPrestamoModel 
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
