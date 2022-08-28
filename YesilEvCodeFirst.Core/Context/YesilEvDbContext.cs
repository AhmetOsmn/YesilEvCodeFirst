using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using YesilEvCodeFirst.Core.Entities;

namespace YesilEvCodeFirst.Core.Context
{
    public class YesilEvDbContext : DbContext
    {
        public YesilEvDbContext() : base("name=AhmetConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            // FavoriListUrun Tablosu
            modelBuilder.Entity<FavList>()
             .HasMany(lst => lst.Products)
             .WithMany(product => product.FavLists)
             .Map(map =>
             {
                 map.ToTable("ProductFavor");
                 map.MapLeftKey("FavorID");
                 map.MapRightKey("ProductID");
             });


            // KaralisteMadde Tablosu
            modelBuilder.Entity<BlackList>()
                .HasMany(lst => lst.Supplements)
                .WithMany(supplement => supplement.BlackLists)
                .Map(map =>
                {
                    map.ToTable("BlackListSupplement");
                    map.MapLeftKey("BlackListID");
                    map.MapRightKey("SupplementID");
                });

            // UrunMadde Tablosu
            modelBuilder.Entity<Product>()
              .HasMany(product => product.Supplements)
              .WithMany(supplement => supplement.Products)
              .Map(map =>
              {
                  map.ToTable("ProductSupplement");
                  map.MapLeftKey("ProductID");
                  map.MapRightKey("SupplementID");
              });
        }

        public DbSet<BlackList> BlackList { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<FavList> FavList{ get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Supplement> Supliment { get; set; }
        public DbSet<Supplier> Supplier { get; set; }


    }
}
