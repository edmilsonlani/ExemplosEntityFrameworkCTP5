using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutorialEntityFrameworkCTP.Modelo
{
    public class Autor
    {
        public virtual int AutorID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string SobreNome { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }

    }
}
