using Microsoft.AspNetCore.Mvc;
using LoginBlazorApp.Shared;
using Microsoft.AspNetCore.Http;
namespace LoginBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        //Simulacion de recoleccion de datos de una base de datos y devolviendo la informacion
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {

            SesionDTO sesionDTO = new SesionDTO();
            if (login.Correo == "admin@gmail.com" && login.Clave == "admin")
            {
                sesionDTO.Nombre = "admin";
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Administrador";
            }
            else
            {
                sesionDTO.Nombre = "empleado";
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Empleado";
            }
            return StatusCode(StatusCodes.Status200OK, sesionDTO);
        }
    }
}
