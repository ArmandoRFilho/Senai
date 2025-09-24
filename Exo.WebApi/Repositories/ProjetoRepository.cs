using ExoApi.Contexts;
using ExoApi.Domains;

 
 namespace ExoApi.Repository
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _context;
        
        public ProjetoRepository(ExoApiContext context)
        {
            _context = context;
        }
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}
