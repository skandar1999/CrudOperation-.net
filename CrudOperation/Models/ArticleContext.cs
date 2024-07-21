using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ProductFamily> ProductFamilies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ServiceCase> ServiceCases { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasOne(a => a.ProductFamily)
                .WithMany(pf => pf.Articles)
                .HasForeignKey(a => a.ProductFamilyID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
