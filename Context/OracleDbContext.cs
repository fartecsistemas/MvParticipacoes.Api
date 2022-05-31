using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MvParticipacoes.Api.Entidades;

namespace MvParticipacoes.Api.Context
{
    public class OracleDbContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public OracleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TSIEMP> TSIEMP { get; set; }
        public DbSet<TSICUS> TSICUS { get; set; }
        public DbSet<TGFNAT> TGFNAT { get; set; }                
        public DbSet<AD_FORMATODRE> AD_FORMATODRE { get; set; }
        public DbSet<AD_PBIDRE> AD_PBIDRE { get; set; }
        public DbSet<AD_PBIRENTABILIDADE> AD_PBIRENTABILIDADE { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TSIEMP>().ToTable("TSIEMP");
            modelBuilder.Entity<TSICUS>().ToTable("TSICUS");
            modelBuilder.Entity<TGFNAT>().ToTable("TGFNAT");            
            modelBuilder.Entity<AD_FORMATODRE>().ToTable("AD_FORMATODRE");            
            modelBuilder.Entity<AD_PBIDRE>().ToTable("AD_PBIDRE");
            modelBuilder.Entity<AD_PBIRENTABILIDADE>().ToTable("AD_PBIRENTABILIDADE");            
        }
    }    
}
