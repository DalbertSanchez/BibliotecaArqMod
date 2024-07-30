using System.Text;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Web.Models.EstadoPrestamoModel;
using BibliotecaArqMod.EP_Usuario.Web.Models.UsuarioModel;
using BibliotecaArqMod.EP_Usuario.Web.Services.httpClientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BibliotecaArqMod.EP_Usuario.Web.Controllers
{
    public class EstadoPrestamoController : Controller
    {

      
        private readonly IHttpClientService httpClientService;

        public EstadoPrestamoController(IHttpClientService httpClientService)
        {
            this.httpClientService = httpClientService;

        }

        // GET: EstadoPrestamoController1
        public async Task<ActionResult> Index()
        {
            try 
            {

                var estadoPrestamoListResult = await httpClientService.GetAsync<EstadoPrestamoListResult>("EstadoPrestamo/GetEstadoPrestamo");
                if (!estadoPrestamoListResult.success)
                {
                    ViewBag.Message = estadoPrestamoListResult.message;
                    return View();
                }
                return View(estadoPrestamoListResult.data);

            }
            catch(Exception ex) 
            {
                ViewBag.Message = $"Error al obtener la lista de estados de prestamo";
                return View();
            }
           
        }

        // GET: EstadoPrestamoController1/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var estadoPrestamoObjectResult = await httpClientService.GetAsync<EstadoPrestamoObjectResult>($"EstadoPrestamo/GetEstadoPrestamoById?id={id}");
                if (!estadoPrestamoObjectResult.success)
                {
                    ViewBag.Message = estadoPrestamoObjectResult.message;
                    return View();
                }
                return View(estadoPrestamoObjectResult.data);

            }
            catch(Exception ex) 
            { 
                ViewBag.Message = $"Error al obtener los detalles del estado de prestamo por el ID: {id}";
            return View("Error");
            
            }
            
        }

        // GET: EstadoPrestamoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoPrestamoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EstadoPrestamoCreateModel createModel)
        {

            try
            {
                var estadoPrestamoSaveResult = await httpClientService.PostAsync<EstadoPrestamoSaveResult>("EstadoPrestamo/CreateEstadoPrestamo", createModel);
                if (!estadoPrestamoSaveResult.success)
                {
                    ViewBag.Message = estadoPrestamoSaveResult.message;
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = $"Error al crear el estado de prestamo";
                return View(createModel);
            }
        }

        // GET: EstadoPrestamoController1/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var estadoPrestamoObjectResult = await httpClientService.GetAsync<EstadoPrestamoObjectResult>($"EstadoPrestamo/GetEstadoPrestamoById?id={id}");
            if (!estadoPrestamoObjectResult.success)
            {
                ViewBag.Message = estadoPrestamoObjectResult.message;
                return View();
            }
            return View(estadoPrestamoObjectResult.data);
        }

        // POST: EstadoPrestamoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EstadoPrestamoUpdateDto estadoPrestamoUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(estadoPrestamoUpdateDto);
            }

            try
            {
                var result = await httpClientService.PostAsync<UsuarioObjectResult>("EstadoPrestamo/UpdateEstadoPrestamo", estadoPrestamoUpdateDto);
                if (result.success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = result.message;
                    return View(estadoPrestamoUpdateDto);
                }
            }
            catch(Exception ex) 
            {
                ViewBag.Message = $"Ocurrio un error al actualizar el estado de prestamo";
                return View(estadoPrestamoUpdateDto);
            }
        }

    }
}
