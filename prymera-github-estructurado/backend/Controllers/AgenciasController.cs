using Microsoft.AspNetCore.Mvc;
using PrymeraApi.Data;

namespace PrymeraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgenciasController : ControllerBase
    {
        private readonly PrymeraRepository _repository;

        public AgenciasController(PrymeraRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repository.Agencias);
        }
    }
}
