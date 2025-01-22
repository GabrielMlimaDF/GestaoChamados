﻿using GestaoChamados.Data.Mappings;
using GestaoChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoChamados.Data
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoMap());
        }
    }
}
