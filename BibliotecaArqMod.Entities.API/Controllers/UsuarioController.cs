using BibliotecaArqMod.EP_Usuario.Application.Dtos.UsuariosDto_s;
using BibliotecaArqMod.EP_Usuario.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaArqMod.EP_Usuario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet("GetUsuarios")]
        public IActionResult Get()
        {
            var result = this.usuarioService.GetEntity();

            if (!result.Success)
            return BadRequest(result);
            
            else
            return Ok(result);
            
        }


        [HttpGet("GetUsuariosByID")]
        public IActionResult Get(int id)
        {
            var result = this.usuarioService.GetEntityByID(id);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost ("CreateUsuarios")]
        public IActionResult Post([FromBody] UsuarioCreateDto usuarioCreateDto)
        {
            var result = this.usuarioService.Create(usuarioCreateDto);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost("UpdateUsuarios")]
        public IActionResult Put(UsuarioUpdateDto usuarioUpdate)
        {
            var result = this.usuarioService.Update(usuarioUpdate);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }


        [HttpPost("DeleteUsuarios")]
        public IActionResult Delete(UsuarioDeleteDto usuarioDelete)
        {
            var result = this.usuarioService.Delete(usuarioDelete);

            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
        }
    }
}
