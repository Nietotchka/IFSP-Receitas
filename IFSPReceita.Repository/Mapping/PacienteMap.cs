using IFSPReceita.Domain.Base;
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
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Numero);

            builder.Property(prop => prop.Bairro)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telefone);

            builder.Property(prop => prop.Convenio)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.NumeroConvenio)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CPF);
               

        }
    }
}
