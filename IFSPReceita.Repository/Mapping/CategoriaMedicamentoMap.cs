using IFSPReceita.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Repository.Mapping
{
    public class CategoriaMedicamentoMap : IEntityTypeConfiguration<CategoriaMedicamento>
    {
        public void Configure(EntityTypeBuilder<CategoriaMedicamento> builder)
        {
            builder.ToTable("CategoriaMedicamento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Categoria)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}
