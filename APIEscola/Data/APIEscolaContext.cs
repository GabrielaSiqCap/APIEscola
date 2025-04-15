// Codigo do Arquivo 
using APIEscola.Models;
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
        public DbSet<Aluno> Alunos { get; set; } //Tabela Alunos
        public DbSet<Curso> Cursos { get; set; } //Tabela Cursos
        public DbSet<Turma> Turmas { get; set; } //Tabela Turmas
        public DbSet<Matricula> Matriculas { get; set; } //Tabela Matriculas

        //Sobrecarga do metodo OnModelCreating para configurar o modelo  a partir do IdentityDbContext 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método OnModelCreating da classe base para a criação de tabelas padrão
            base.OnModelCreating(modelBuilder);
            // Configurar a criação de tabelas adicionais aqui
            modelBuilder.Entity<Aluno>().ToTable("Alunos"); //Configura o nome da tabela Alunos
            modelBuilder.Entity<Curso>().ToTable("Cursos"); //Configura o nome da tabela Cursos
            modelBuilder.Entity<Turma>().ToTable("Turmas"); //Configura o nome da tabela Turmas
            modelBuilder.Entity<Matricula>().ToTable("Matriculas"); //Configura o nome da tabela Matriculas
        }
    }
}


// =========================================================================================