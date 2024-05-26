using BLOGAPI.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BLOGAPI.src.Base.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Comentarios> comentarios { get; set; }

    }

   

}
