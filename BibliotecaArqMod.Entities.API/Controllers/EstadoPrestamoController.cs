using BibliotecaArqMod.EP_Usuario.Application.Dtos.EstadoPrestamoDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaArqMod.EP_Usuario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoPrestamoController : ControllerBase
    {

        private readonly IEstadoPrestamoService estadoPrestamoService;

        public EstadoPrestamoController(IEstadoPrestamoService estadoPrestamoService)
        {
            this.estadoPrestamoService = estadoPrestamoService;
        }

      
        [HttpGet("GetEstadoPrestamo")]
        public IActionResult Get()
        {
            var result = this.estadoPrestamoService.GetEntity();

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpGet("GetEstadoPrestamoById")]
        public IActionResult Get(int id)
        {
            var result = this.estadoPrestamoService.GetEntityByID(id);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost("CreateEstadoPrestamo")]
        public IActionResult Post([FromBody] EstadoPrestamoCreateDto estadoPrestamoCreate)
        {
            var result = this.estadoPrestamoService.Create(estadoPrestamoCreate);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost("UpdateEstadoPrestamo")]
        public IActionResult Put(EstadoPrestamoUpdateDto estadoPrestamoUpdate)
        {
            var result = this.estadoPrestamoService.Update(estadoPrestamoUpdate);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost ("DeleteEstadoPrestamo")]
        public IActionResult Delete(EstadoPrestamoDeleteDto estadoPrestamoDelete)
        {
            var result = this.estadoPrestamoService.Delete(estadoPrestamoDelete);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }
    }
}
