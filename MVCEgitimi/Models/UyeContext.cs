using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics; // pending hatası için

namespace MVCEgitimi.Models
{
    public class UyeContext : DbContext// DbContext sınıfı Nuget dan yüklediğimiz entity framework core paketleri ile gelmektedir ve ef ile veritabanı işlemlerini yapabilmemizi sağlar.
    {
        public DbSet<Uye> Uyeler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=UyelerSH; integrated security=true; TrustServerCertificate=True");
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); // veritabanı oluştururken aldığımız PendingModelChangesWarning hatasının çözümü için
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uye>().HasData(
                new Uye
                {
                    Id = 1,
                    Email = "admin@admin.com",
                    Ad = "Admin",
                    Soyad = "User",
                    DogumTarihi = DateTime.Now,
                    KullaniciAdi = "admin",
                    Sifre = "123",
                    SifreTekrar = "123",
                    TcKimlikNo = "12345678901",
                    Telefon = "12345678901"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
