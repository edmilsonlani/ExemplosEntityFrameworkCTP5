using System;
using System.Collections.Generic;
using System.Data.Entity.Database;
using System.Linq;
using System.Text;
using TutorialEntityFrameworkCTP.Infra;
using TutorialEntityFrameworkCTP.Modelo;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
namespace TutorialEntityFrameworkCTP.Console
{
    class Program
    {
      
        static void Main(string[] args)
        {
            using (var contexto = new ContextoEF())
            {
                DbDatabase.SetInitializer(new NeverChangeDatabase());
                Livraria livrariaCultura = new Livraria();
                livrariaCultura.Nome = "Livraria cultura";
                livrariaCultura.Telefone = "4444-5555";
                contexto.Livrarias.Add(livrariaCultura);
                contexto.SaveChanges();
                System.Console.ReadKey();
            }
            /*
                contexto.Database.CreateIfNotExists();
                Autor JrrTolkien = new Autor() { Nome = "John", AutorID = 1, SobreNome = "Tolkien" };
                Livro senhorDosAneis = new Livro();
                senhorDosAneis.Autor = JrrTolkien;
                Editora editora = new Editora() { EditoraID = 2, Nome = "Editor" };
                senhorDosAneis.Editora = editora;
                senhorDosAneis.DataPrimeiraEdicao = DateTime.Now;
                senhorDosAneis.Titulo = "Senhor dos aneis";
                contexto.Livros.Add(senhorDosAneis);
                System.Console.WriteLine("Quantidade de livros:" + JrrTolkien.Livros.Count());
                contexto.SaveChanges();
                System.Console.ReadKey();
                 */
            //}

        }
    }
}
