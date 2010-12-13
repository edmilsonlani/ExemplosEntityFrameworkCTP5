using System.Data.Entity;
using TutorialEntityFrameworkCTP.Modelo;

namespace TutorialEntityFrameworkCTP.Infra
{
    public class ContextoEF : DbContext
    {
        public IDbSet<Livro> Livros { get; set; }
        public IDbSet<Autor> Autores { get; set; }
        public IDbSet<Editora> Editores { get; set; }

        protected override void OnModelCreating(System.Data.Entity.ModelConfiguration.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().HasKey(l => l.ISBN).ToTable("Livros");
            modelBuilder.Entity<Autor>().HasKey(a => a.AutorID).ToTable("Autores");
            modelBuilder.Entity<Editora>().HasKey(a => a.EditoraID).ToTable("Editoras");

        }
    }
}
