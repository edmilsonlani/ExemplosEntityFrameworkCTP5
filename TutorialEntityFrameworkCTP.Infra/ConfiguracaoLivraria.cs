using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using TutorialEntityFrameworkCTP.Modelo;

namespace TutorialEntityFrameworkCTP.Infra
{
    public class ConfiguracaoLivraria : EntityTypeConfiguration<Livraria>
    {
        public ConfiguracaoLivraria()
        {
            HasKey(livraria => livraria.LivrariaID);
            Property(livraria => livraria.LivrariaID).HasColumnName("BookStoreID");
            Property(livraria => livraria.Nome).HasColumnName("Name");
            Property(livraria => livraria.Telefone).HasColumnName("PhoneNumber");
            ToTable("BookStores");
        }
    }
}
