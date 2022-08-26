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

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // KullaniciMadde Tablosu
            modelBuilder.Entity<Kullanici>()
                .HasMany(kullanici => kullanici.Maddeler)
                .WithMany(madde => madde.Kullanicilar)
                .Map(map =>
                {
                    map.ToTable("KullaniciMadde");
                    map.MapLeftKey("KullaniciID");
                    map.MapLeftKey("MaddeID");
                });

            // UrunMadde Tablosu
            modelBuilder.Entity<Urun>()
                .HasMany(urun => urun.Maddeler)
                .WithMany(madde => madde.Urunler)
                .Map(map =>
                {
                    map.ToTable("UrunMadde");
                    map.MapRightKey("UrunID");
                    map.MapLeftKey("MaddeID");
                });

            // RolYetki Tablosu
            modelBuilder.Entity<Rol>()
                .HasMany(rol => rol.Yetkiler)
                .WithMany(yetki => yetki.Roller)
                .Map(map =>
                {
                    map.ToTable("RolYetki");
                    map.MapLeftKey("RolID");
                    map.MapLeftKey("YetkiID");
                });


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Madde> Madde { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Uretici> Uretici { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Yetki> Yetki { get; set; }


    }
}
