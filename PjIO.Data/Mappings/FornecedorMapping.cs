using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PjIO.Businnes.Models;

namespace PjIO.Data.Mappings
{
    public partial class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> buider)
        {
            buider.HasKey(keyExpression: p => p.Id);

            buider.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            buider.Property(p => p.Documentos)
              .IsRequired()
              .HasColumnType("varchar(1000)");

            buider.Property(p => p.CNPJ)
              .IsRequired()
              .HasColumnType("varchar(14)");


            //Mapeamento 1 : 1 => Fornecedor : Endereco
            buider.HasOne(navigationExpression: f => f.Endereco)
                .WithOne(navigationExpression: e => e.Fornecedor);

            //Mapeamento 1 : N => Fornecedor : Produto
            buider.HasMany(navigationExpression: f => f.Produtos)
                .WithOne(navigationExpression: p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId);


            buider.ToTable("Forncedores");
        }
    }
}

/*Fazer baixar o pacote Install-Package Microsoft.EntityFrameworkCore.Relational */
