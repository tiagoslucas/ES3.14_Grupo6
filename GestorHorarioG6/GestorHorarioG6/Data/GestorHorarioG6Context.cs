﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorHorarioG6.Models;

namespace GestorHorarioG6.Data
{
    public class GestorHorarioG6Context : DbContext
    {
        public GestorHorarioG6Context(DbContextOptions<GestorHorarioG6Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelbuilder);
        }

        public DbSet<GestorHorarioG6.Models.Funcionario> Funcionario { get; set; }
        
        public DbSet<GestorHorarioG6.Models.Trocas> Trocas { get; set; }

        public DbSet<GestorHorarioG6.Models.Requisicao> Requisicao { get; set; }

        public DbSet<GestorHorarioG6.Models.Departamento> Departamento { get; set; }

        public DbSet<GestorHorarioG6.Models.Servico> Servico { get; set; }

        public DbSet<GestorHorarioG6.Models.Cargo> Cargo { get; set; }

        public DbSet<GestorHorarioG6.Models.Turno> Turno { get; set; }

        public DbSet<GestorHorarioG6.Models.RequisicaoDetalhe> RequisicaoDetalhe { get; set; }

        public DbSet<GestorHorarioG6.Models.HorarioTecnicos> HorarioTecnicos { get; set; }

        public DbSet<GestorHorarioG6.Models.HorarioATrocar> HorarioATrocar { get; set; }

        public DbSet<GestorHorarioG6.Models.HorarioParaTroca> HorarioParaTroca { get; set; }

        public DbSet<GestorHorarioG6.Models.Estado> Estado { get; set; }

    }
}
