 using Microsoft.EntityFrameworkCore;
 using ExoApi.Domains;
 
 namespace ExoApi.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depende da SUA máquina.
                optionsBuilder.UseSqlServer("Data source = localhost; initial catalog = ExoApi; Integrated Security = True; TrusteServerCertificate=True;");
                // Exemplo 1 de string de conexão:
                // User
                //ID = sa; Password = admin; Server = localhost; Database = ExoApi;
                // + Trusted_Connection=False; 
                // Exemplo 2 de string de conexão:
                // 
                //Server = localhost\\SQLEXPRESS; Database = ExoApi; Trusted_Connection = True;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}