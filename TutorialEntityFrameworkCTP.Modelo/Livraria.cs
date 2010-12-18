using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutorialEntityFrameworkCTP.Modelo
{
    public class Livraria
    {
        public virtual int LivrariaID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }
    }
}
