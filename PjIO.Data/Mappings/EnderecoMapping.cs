using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PjIO.Businnes.Models;

namespace PjIO.Data.Mappings
{
    public partial class FornecedorMapping
    {
        public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
        {
            public void Configure(EntityTypeBuilder<Endereco> buider)
            {
                buider.HasKey(keyExpression: p => p.Id);

                buider.Property(c => c.Logradouro)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                buider.Property(c => c.Numero)
                  .IsRequired()
                  .HasColumnType("varchar(50)");

                buider.Property(c => c.Cep)
                  .IsRequired()
                  .HasColumnType("varchar(50)");

                buider.Property(c => c.Complemento)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

                buider.Property(c => c.Bairro)
                 .IsRequired()
                  .HasColumnType("varchar(50)");

                buider.Property(c => c.Cidade)
                 .IsRequired()
                  .HasColumnType("varchar(50)");

                buider.Property(c => c.Estado)
               .IsRequired()
                .HasColumnType("varchar(50)");

                buider.ToTable("Enderecos");
            }
        }
    }
}

/*Fazer baixar o pacote Install-Package Microsoft.EntityFrameworkCore.Relational */
