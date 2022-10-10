using Microsoft.EntityFrameworkCore;
using PjIO.Businnes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjIO.Data.Context
{
    public class PjDevsCondext : DbContext
    {
        public PjDevsCondext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedors { get; set; }

        public DbSet<Produto> Produtos { get; set; }


       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PjDevsCondext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }  
    }
}
