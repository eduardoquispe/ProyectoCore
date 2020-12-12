using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Persistencia
{
    public class CursosOnlineContext : DbContext
    {
        public CursosOnlineContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoDocente>().HasKey(ci => new { ci.DocenteId, ci.CursoId });
        }

        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<CursoDocente> CursoDocente { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Precio> Precio { get; set; }
    }
}
