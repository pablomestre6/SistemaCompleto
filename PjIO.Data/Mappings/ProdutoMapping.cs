using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PjIO.Businnes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjIO.Data.Mappings
{

    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> buider)
        {
            buider.HasKey(keyExpression: p => p.Id);

            buider.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            buider.Property(p => p.Descricao)
              .IsRequired()
              .HasColumnType("varchar(1000)");

            buider.Property(p => p.Imgagem)
              .IsRequired()
              .HasColumnType("varchar(100)");

            buider.ToTable("Produtos");
        }
    }
}

/*Fazer baixar o pacote Install-Package Microsoft.EntityFrameworkCore.Relational */
