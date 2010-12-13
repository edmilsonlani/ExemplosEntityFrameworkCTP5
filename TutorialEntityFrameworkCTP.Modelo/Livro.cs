using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutorialEntityFrameworkCTP.Modelo
{
        public class Livro
        {
            public virtual int ISBN { get; set; }
            public virtual string Titulo { get; set; }
            public virtual DateTime DataPrimeiraEdicao { get; set; }
            public virtual Autor Autor { get; set; }
            public virtual Editora Editora { get; set; }
        }

}



