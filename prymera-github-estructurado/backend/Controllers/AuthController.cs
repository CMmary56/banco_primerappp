using Microsoft.AspNetCore.Mvc;
using PrymeraApi.Data;
using PrymeraApi.Dtos;
using PrymeraApi.Utils;

namespace PrymeraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly PrymeraRepository _repository;

        public AuthController(PrymeraRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto request)
        {
            string hash = PasswordHasher.Hash(request.Password);

            var usuario = _repository.Usuarios.FirstOrDefault(u =>
                u.Correo == request.Correo && u.PasswordHash == hash);

            if (usuario == null)
            {
                return Unauthorized(new { mensaje = "Credenciales incorrectas" });
            }

            return Ok(new
            {
                mensaje = "Inicio de sesión correcto",
                usuario = new { usuario.Id, usuario.Nombres, usuario.Apellidos, usuario.Correo }
            });
        }
    }
}
