using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telstar.Domain.Entities;

namespace Telstar.Infra.Data.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            HasKey(e => e.IdEndereco);

            Property(e => e.IdEndereco)
               .HasColumnName("IdEndereco")
               .IsRequired();

            Property(e => e.Logradouro)
               .HasColumnName("Logradouro")
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();

            Property(e => e.Cidade)
               .HasColumnName("Cidade")
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();

            Property(e => e.CEP)
               .HasColumnName("CEP")
               .HasMaxLength(9)
               .HasColumnType("char")
               .IsRequired();

            HasRequired(e => e.Cliente)
                .WithOptional( c => c.Endereco);
        }
    }
}
