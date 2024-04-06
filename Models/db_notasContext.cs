using L01P022019AC603.Models;
using Microsoft.EntityFrameworkCore;

namespace _2021MD601.Models
{
    public class db_notasContext:DbContext
    {
        public db_notasContext(DbContextOptions<db_notasContext> options) : base(options)
        {

        }

        public DbSet<materias> materias { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<alumnos> alumnos { get; set; }

    }
}
