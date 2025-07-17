using System.Data.Entity; // Entity framework kütüphanesini ekledik
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntityFramework
{
    public class UrunDbModel : DbContext // Entity frameworkün DbContext sınıfından miras alıyoruz
    {
        public UrunDbModel() : base("name=UrunDbModel") // Entity frameworkün DbContext sınıfındaki base e connection string ismini gönderdik
        {
            
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}
