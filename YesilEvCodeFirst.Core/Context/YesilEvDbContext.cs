using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using YesilEvCodeFirst.Core.Entities;

namespace YesilEvCodeFirst.Core.Context
{
    public class YesilEvDbContext : DbContext
    {
        public YesilEvDbContext() : base("name=AhmetConn")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            #region ProductFavList

            modelBuilder.Entity<ProductFavList>()
               .HasKey(t => new { t.ProductID, t.FavListID });

            modelBuilder.Entity<ProductFavList>()
               .HasRequired(pf => pf.Product)
               .WithMany(p => p.ProductFavList)
               .HasForeignKey(pf => pf.ProductID);

            modelBuilder.Entity<ProductFavList>()
                .HasRequired(pf => pf.FavList)
                .WithMany(fl => fl.ProductFavList)
                .HasForeignKey(pf => pf.FavListID);

            #endregion

            #region ProductSupplement

            modelBuilder.Entity<ProductSupplement>()
                .HasKey(t => new { t.ProductID, t.SupplementID });

            modelBuilder.Entity<ProductSupplement>()
                .HasRequired(ps => ps.Product)
                .WithMany(p => p.ProductSupplements)
                .HasForeignKey(ps => ps.ProductID);

            modelBuilder.Entity<ProductSupplement>()
                .HasRequired(ps => ps.Supplement)
                .WithMany(p => p.ProductSupplements)
                .HasForeignKey(ps => ps.SupplementID);

            #endregion

            #region SupplementBlackList

            modelBuilder.Entity<SupplementBlackList>()
                .HasKey(t => new { t.SupplementID, t.BlackListID });

            modelBuilder.Entity<SupplementBlackList>()
                .HasRequired(sb => sb.Supplement)
                .WithMany(s => s.SupplementBlackLists)
                .HasForeignKey(sb => sb.SupplementID);

            modelBuilder.Entity<SupplementBlackList>()
                .HasRequired(sb => sb.BlackList)
                .WithMany(bl => bl.SupplementBlackLists)
                .HasForeignKey(sb => sb.BlackListID);

            #endregion

        }

        public DbSet<BlackList> BlackList { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FavList> FavList { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Supplement> Supplement { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductSupplement> ProductSupplement { get; set; }
        public DbSet<SupplementBlackList> SupplementBlackList { get; set; }
        public DbSet<ProductFavList> ProductFavList { get; set; }
        public DbSet<SearchHistory> SearchHistory { get; set; }
    }
}
