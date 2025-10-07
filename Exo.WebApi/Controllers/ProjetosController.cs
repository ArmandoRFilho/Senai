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
        
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            _projetoRepository.Cadastrar(projeto);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, Projeto projeto)
        {
            Projeto projetoBusacado = _projetoRepository.BuscarPorId(id);

            if (projetoBusacado == null)
            {
                return StatusCode(404);
            }
            _projetoRepository.Alterar(id, projeto);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirProduto(int id)
        {
            Projeto projeto = _projetoRepository.BuscarPorId(id);

            if (projeto == null)
            {
                return StatusCode(404);
            }
            _projetoRepository.Excluir(id);

            return StatusCode(204);
        }
    }
}