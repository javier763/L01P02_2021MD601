using Microsoft.EntityFrameworkCore;

namespace L01P022019AC603.Models
{
    public class db_notasContext:DbContext
    {

        public db_notasContext(DbContextOptions<db_notasContext> options) : base(options)
        {

        }

        public DbSet<materias> materias { get; set; }
        public DbSet<facultades> facultades { get; set;}
        public DbSet<departamentos> departamentos { get; set;}
        public DbSet<alumnos> alumnos { get; set;}


    }
}
