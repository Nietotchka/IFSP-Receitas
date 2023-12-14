using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IFSPReceita.Repository.Mapping;
using IFSPReceita.Domain.Entities;

namespace IFSPReceita.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
            public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
            {
                Database.EnsureCreated();
                ChangeTracker.LazyLoadingEnabled = false;
            }

            public DbSet<CategoriaMedicamento>? CategoriaMedicamento { get; set; }
            public DbSet<Medicamento>? Medicamento { get; set; }
            public DbSet<Medico>? Medico { get; set; }
            public DbSet<Paciente>? Paciente { get; set; }
            public DbSet<Receita>? Receita { get; set; }
          


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<CategoriaMedicamento>(new CategoriaMedicamentoMap().Configure);
                modelBuilder.Entity<Medicamento>(new MedicamentoMap().Configure);
                modelBuilder.Entity<Medico>(new MedicoMap().Configure);
                modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
                modelBuilder.Entity<Receita>(new ReceitaMap().Configure);
            }
        }
    }
