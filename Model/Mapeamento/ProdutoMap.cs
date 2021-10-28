using APIADS2.Model.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIADS2.Model.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.descricao).HasMaxLength(35).IsRequired();
            builder.Property(p => p.unidade).HasMaxLength(5).IsRequired();
            builder.Property(p => p.quantidade).HasColumnType("Float").IsRequired();
            builder.Property(p => p.valor).HasColumnType("Float").IsRequired();

            builder.ToTable("Produtos"); 
        }
    }
}
