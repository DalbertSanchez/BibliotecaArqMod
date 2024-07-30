namespace BibliotecaArqMod.EP_Usuario.Web.Models
{
    public class BaseReult<TModel>
    {
        public bool success { get; set; }
        public object message { get; set; }
        public TModel? data { get; set; }
    }
}
