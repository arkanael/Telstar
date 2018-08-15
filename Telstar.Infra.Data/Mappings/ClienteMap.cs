using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telstar.Domain.Entities;

namespace Telstar.Infra.Data.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(c => c.IdCliente);

            Property(c => c.IdCliente)
               .HasColumnName("IdCliente")
               .IsRequired();

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Email)
               .HasColumnName("Email")
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();

            Property(c => c.DataNascimento)
               .HasColumnName("DataNascimento")
               .HasColumnType("varchar")
               .IsRequired();

            HasOptional(c => c.Endereco)
                .WithRequired(e => e.Cliente);
        }
    }
}
