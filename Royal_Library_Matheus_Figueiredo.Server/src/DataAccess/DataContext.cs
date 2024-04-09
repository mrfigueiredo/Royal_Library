using Microsoft.EntityFrameworkCore;
using Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Models;

namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess
{
    public partial class DataContext : DbContext
    {
        public  DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity => {
                entity.HasKey(k => k.book_id);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Book> Books { get; set; }

    }

}
