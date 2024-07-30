using System.Net.Security;
using System.Text;
using System.Text.Json.Serialization;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Web.Models.UsuarioModel;
using BibliotecaArqMod.EP_Usuario.Web.Services.httpClientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace BibliotecaArqMod.EP_Usuario.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IHttpClientService httpClientService;

        public UsuarioController(IHttpClientService httpClientService)
        {
            this.httpClientService = httpClientService;
        }

        // GET: UsuarioController1
        public async Task<ActionResult> Index()
        {
            try 
            {

                var usuarioListResult = await httpClientService.GetAsync<UsuarioListResult>("Usuario/GetUsuarios");
                if (!usuarioListResult.success)
                {
                    ViewBag.Message = usuarioListResult.message;
                    return View();
                }
                return View(usuarioListResult.data);

            }
            catch (Exception ex) 
            
            {
                ViewBag.Message = $"Error al obtener la lista de usuarios";
                return View();
            }
            
        }

        // GET: UsuarioController1/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try 
            {
                var usuarioObjectResult = await httpClientService.GetAsync<UsuarioObjectResult>($"Usuario/GetUsuariosByID?id={id}");
                if (!usuarioObjectResult.success)
                {
                    ViewBag.Message = usuarioObjectResult.message;
                    return View();
                }
                return View(usuarioObjectResult.data);
            }
            catch(Exception ex) 
            {
                ViewBag.Message = $"Error al obtener los detalles del usuario por el ID: {id}";
                return View("Error");

            }
           
        }

        // GET: UsuarioController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UsuarioCreateModel createModel)
        {
            try
            {
                var usuarioSaveResult = await httpClientService.PostAsync<UsuarioSaveResult>("Usuario/CreateUsuarios", createModel);
                if (!usuarioSaveResult.success)
                {
                    ViewBag.Message = usuarioSaveResult.message;
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Message = $"Error al crear el usuario";
                return View(createModel);
            }
        }

        // GET: UsuarioController1/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var usuarioObjectResult = await httpClientService.GetAsync<UsuarioObjectResult>($"Usuario/GetUsuariosByID?id={id}");
            if (!usuarioObjectResult.success)
            {
                ViewBag.Message = usuarioObjectResult.message;
                return View();
            }
            return View(usuarioObjectResult.data);
        }


        // POST: UsuarioController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UsuarioUpdateDto usuarioUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(usuarioUpdateDto);
            }

            try
            {
                var result = await httpClientService.PostAsync<UsuarioObjectResult>("Usuario/UpdateUsuarios", usuarioUpdateDto);
                if (result.success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = result.message;
                    return View(usuarioUpdateDto);
                }
            }
            catch
            {
                ViewBag.Message = "Ocurrio un error al actualizar el usuario.";
                return View(usuarioUpdateDto);
            }
        }






    }
}
