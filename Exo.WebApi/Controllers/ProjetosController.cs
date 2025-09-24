using ExoApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

 namespace ExoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        [HttpGet]
        public IActionResult GetProjetos()
        {
            return StatusCode(200, _projetoRepository.Listar());
        }
    }
}