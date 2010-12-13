using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutorialEntityFrameworkCTP.Modelo
{
    public class Editora
    {
        public virtual int EditoraID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
