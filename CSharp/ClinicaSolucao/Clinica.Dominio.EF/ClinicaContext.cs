﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dominio.EF
{
    public partial class ClinicaContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; } = null!;

        public DbSet<Consulta> Consultas { get; set; } = null!;

        public DbSet<Servico> Servicos { get; set; } = null!;

        public ClinicaContext() : base()
        { }

        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>(entity => 
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
