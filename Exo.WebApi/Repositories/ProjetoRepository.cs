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

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);

            _context.SaveChanges();
        }

        public void Alterar(int id, Projeto projeto)
        {
            Projeto projeto1 = _context.Projetos.Find(id);
            if (projeto1.NomeDoProjeto != null) {
                projeto1.NomeDoProjeto = projeto.NomeDoProjeto;
            }
            if (projeto1.Area != null) {
                projeto1.Area = projeto.Area;
            }
            if (projeto1.Status != null) {
                projeto1.Status = projeto.Status;
            }

            _context.Projetos.Update(projeto1);

            _context.SaveChanges();
        }
        public void BuscarPorId(int id) {
            Projeto projeto = _context.Projetos.Find(id);

        }
        public void Excluir(int id) {
            Projeto projeto = _context.Projetos.Find(id);

            _context.Projetos.Remove(projeto);

            _context.SaveChanges();
        }
    }
}
