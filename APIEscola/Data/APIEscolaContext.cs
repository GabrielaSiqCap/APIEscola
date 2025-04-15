// Codigo do Arquivo 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Ele herda todas as tabelas de IdentityDbContext
    {
        // Construtor que recebe as opções de configuração do DbContext
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }
        //Propriedade DbSet para cada tabela

        //Sobrecarga do metodo OnModelCreating para configurar o modelo  a partir do IdentityDbContext 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método OnModelCreating da classe base para a criação de tabelas padrão
            base.OnModelCreating(modelBuilder);
            // Configurar a criação de tabelas adicionais aqui
        }
    }
}


// =========================================================================================