using habrservice.Models;

using Microsoft.EntityFrameworkCore;

namespace habrservice.EF
{
    public class AppDbContext:DbContext
    {      
         public DbSet<Author> Authors{ get; set; }
         public DbSet<Article> Articles { get; set; }
         public DbSet<Hub> Hubs { get; set; }
         public DbSet<Comment> Coments { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasMany(a=>a.Comments).WithOne(c=>c.Author).OnDelete(DeleteBehavior.NoAction).HasForeignKey(c=>c.AuthorId);

            modelBuilder.Entity<Author>().HasMany(s=>s.Articles).WithOne(a=>a.Author).OnDelete(DeleteBehavior.NoAction).HasForeignKey(a=>a.AuthorId);  
            
            modelBuilder.Entity<Hub>().HasMany(h=>h.Articles).WithOne(a=>a.Hub).OnDelete(DeleteBehavior.NoAction).HasForeignKey(a=>a.HubId);

            modelBuilder.Entity<Article>().HasMany(a => a.Comments).WithOne(c => c.Article).OnDelete(DeleteBehavior.NoAction).HasForeignKey(c =>c.ArticleId);     
        }
    }
}
