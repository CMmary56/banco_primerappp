using Microsoft.AspNetCore.Mvc;
using PrymeraApi.Data;

namespace PrymeraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly PrymeraRepository _repository;

        public ProductosController(PrymeraRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repository.Productos);
        }
    }
}
